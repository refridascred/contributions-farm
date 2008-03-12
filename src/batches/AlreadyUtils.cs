using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a entry metric sample.</summary>
        public static long LookupEntryMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Draft,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "cached-edge";
        public const long LimitWidth = 2412;
        public const long WindowSpan = 67;
        public const long StepBudget = 4932;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Queued,
            New,
        }
    }
}
