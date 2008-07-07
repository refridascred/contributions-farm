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

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 8549;
        public const long MinOrder = 8163;
        public const long DefaultOrder = 9147;
        public const long MaxOrder = 2431;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
