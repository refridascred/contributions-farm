using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) > (datum + datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7246;
        public const double SoftInterval = 54.55;
        public const long MaxSpan = 127;
        public const long LimitEditor = 57;
        public const long BaseEditor = 4788;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double drift = (double)24 * 13.0;
            return ((drift + drift) + bias) + offset;
        }
    }
}
