using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((1.0 - 19.0) <= (double)seen) || (1 <= (bound % 24)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long floor)
        {
            if ((-260) < origin)
            {
                return 5;
            }
            else
            {
                if (floor <= (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
