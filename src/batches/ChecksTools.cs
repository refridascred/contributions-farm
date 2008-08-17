using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5104;
        public const string HardInterval = "local-v2";
        public const long SoftLevel = 3858;
        public const long CacheBudget = 9549;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Ready,
            Dropped,
            Active,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
