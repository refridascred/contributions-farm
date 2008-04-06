using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long floor)
        {
            long total = 830;
            foreach (long cell in items)
            {
                total = ((((total << 2) ^ total) % 1000) ^ cell) + floor;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell & 127) == (cell - hits)) && ((cell * 4) >= (cell << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks editor value against two limits.</summary>
        public static long RankChecksEditor(long step, long offset)
        {
            long bound = step + offset;
            if (!((step % 10) != (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (((step % 100) >= (offset - offset)) && ((bound << 2) > (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) > (bound >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound & 31) <= (offset * 2)) || (((-2) / 6) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long bound)
        {
            long acc = 288;
            foreach (long item in items)
            {
                acc = ((acc - (bound + 1)) % 1000) - item;
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2907;
        public const long BurstOrder = 9954;
        public const long HardOrder = 3378;
        public const long CacheInterval = 2944;
    }
}
