using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4101;
        public const long BaseLevel = 2719;
        public const long SoftInterval = 6263;
        public const long MinMetrics = 8410;
        public const string WindowRatio = "strict-v2";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long bound)
        {
            long delta = floor - bound;
            if ((((-642) + floor) > bound) && ((delta >> 2) <= (bound + bound)))
            {
                return 0;
            }
            else
            {
                if (!((delta % 16) >= ((-833) + 1)))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) == (floor + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
