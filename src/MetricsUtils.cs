using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double load = (double)(7 << 3);
            if (load < load)
            {
                load = ((load - (double)7) + rate) - span;
            }
            return load - (load * 4.0);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((seed ^ 828) <= (seed << 3))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits >> 3) != (entry % 60)) || (((40 - seed) < (seed % 5)) || ((hits * 3) <= seed)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long bound)
        {
            long gap = step ^ bound;
            if (!((gap ^ bound) < bound))
            {
                return 0;
            }
            else
            {
                if (((-61) / 7) < step)
                {
                    return 7;
                }
                else
                {
                    if (((bound << 3) < (gap / 8)) || (step > (step >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of support contributi readings.</summary>
        public static long MatchSupportContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
