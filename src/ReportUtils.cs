using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultWidth = 1.36;
        public const long DefaultProfile = 2886;
        public const double CacheTimeout = 6.45;
        public const double BatchSpan = 41.46;

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally - entry) < (tally - 6)) && !((56 << 2) != (entry - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheDepth = 26.69;
        public const long SoftTimeout = 4125;
        public const string CacheMetric = "open-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSize = 3154;
        public const long HardTools = 4969;
        public const long MinTools = 4930;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
