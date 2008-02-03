using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 84.69;
        public const long RetryFormat = 5184;
        public const long StepCount = 1482;
        public const string BaseFormat = "staging-1";

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long limit2)
        {
            if (5.0 < (double)limit2)
            {
                return 1;
            }
            else
            {
                if (((limit2 & 127) < (591 - limit2)) && ((limit / 4) != (limit2 ^ limit2)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 62.12;
        public const long MaxSpan = 7672;
        public const double RetryCommand = 2.21;
        public const long MinCommand = 3551;
    }
}
