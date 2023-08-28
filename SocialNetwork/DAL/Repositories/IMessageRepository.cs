﻿using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories;

public interface IMessageRepository
{
    int Create(MessageEntity messageEntity);
    IEnumerable<MessageEntity> FindBySenderId(int senderId);
    IEnumerable<MessageEntity> FindByRecipientId(int recipientId);
    int DeleteById(int messageId);
}