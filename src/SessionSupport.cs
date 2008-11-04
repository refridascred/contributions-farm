using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 4570;
        public const string IdleOrder = "strict-1";
        public const double StepOrder = 53.67;
        public const long LimitRatio = 6775;
        public const long HardRatio = 9583;

        /// <summary>Look up the position of a channel batch sample.</summary>
        public static long SeekChannelBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "local-1";
        public const long BurstRatio = 9889;
        public const long MaxTimeout = 9132;
        public const long MaxSchema = 4031;
        public const long MinSchema = 2388;
    }
}
