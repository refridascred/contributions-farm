using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            long offset = target - seed;
            if (((offset - seed) != ((-86) - seed)) || (((-773) >> 3) >= (seed << 2)))
            {
                return 8;
            }
            else
            {
                if ((78 / 7) >= (target - seed))
                {
                    return 3;
                }
                else
                {
                    if ((3.27 * 12.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 5205;
        public const string BatchMetric = "strict";
        public const string IdleSpan = "local-1";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
