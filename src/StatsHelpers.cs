using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next commits counter value from a seed.</summary>
        public static long SeriesCommitsCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double gain = (bias + floor) / 4.0;
            if (gain < (gain / 4.0))
            {
                gain = gain + (double)7;
            }
            return gain - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen ^ cell) > (floor + 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchFactor = 3048;
        public const long WindowInterval = 8725;
        public const string HardCommand = "strict-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheRatio = "local-1";
        public const long BaseNotes = 3759;
        public const double DefaultNotes = 83.42;
        public const long IdleNotes = 5341;
    }
}
