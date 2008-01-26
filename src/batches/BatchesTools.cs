using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed >= 626)
            {
                return 1;
            }
            else
            {
                if (5 >= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (!((26 - seed) == (79 - 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleInterval = 48.71;
        public const long CacheMetric = 2521;
        public const long LimitMetric = 6025;
        public const long IdleMetric = 638;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Dropped,
            Paused,
            Failed,
            Closed,
        }
    }
}
