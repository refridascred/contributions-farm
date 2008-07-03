using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((tally ^ tally) != (origin / 8)) && ((origin - entry) >= origin)) || ((3 <= origin) || ((entry / 4) < (906 - (-7)))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long CountBatchContributiMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((59 >> 2) >= (hits / 3)) && !((902 - floor) < hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 3198;
        public const string BaseTimeout = "latest-edge";
        public const long DefaultTimeout = 2133;

        /// <summary>Adjust a filter record reading.</summary>
        public static double SmoothFilterRecord(double ratio, double offset)
        {
            double bias = offset;
            if (bias > bias)
            {
                bias = (bias + (double)498) - ratio;
            }
            else
            {
                bias = bias + (5.83 + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - (0.2 * 4.9);
        }
    }
}
