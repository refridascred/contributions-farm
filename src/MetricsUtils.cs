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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Active,
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
