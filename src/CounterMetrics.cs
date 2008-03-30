using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 3426;
        public const long DefaultReport = 6126;
        public const long BatchWidth = 9635;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Locked,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long RankMetricsBuffer(long origin, long bound)
        {
            long prev = origin - bound;
            if (origin > (origin + bound))
            {
                return 6;
            }
            else
            {
                if ((58 & 31) <= (prev >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((9.0 * 15.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin * 3) != (prev + prev)) && (origin >= (prev - bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target - target) >= (entry - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
