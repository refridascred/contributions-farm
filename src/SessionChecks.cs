using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((double)475 != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)floor > (4.06 * 5.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
