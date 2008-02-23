using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.0 + 3.8) != (double)matches)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double bias = (double)557 / 4.0;
            if (bias <= bias)
            {
                bias = ((bias + bias) + gain) - floor;
            }
            return bias + (double)34;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) == (45 * 5))
                {
                    hits = ((hits + 2) + reading) + seed;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long bound)
        {
            if ((bound * 2) < (17 ^ bound))
            {
                return 1;
            }
            else
            {
                if (((7 % 5) < (bound + origin)) || (7 <= (bound << 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((double)offset < (double)689)
            {
                return 5;
            }
            else
            {
                if ((slot + slot) <= (floor & 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) == (slot - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
