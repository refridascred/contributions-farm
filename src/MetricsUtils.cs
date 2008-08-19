using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two command order measurements.</summary>
        public static double SmoothCommandOrder(double bias, double offset)
        {
            double load = (bias - bias) - (double)506;
            if (load >= (offset * 8.1))
            {
                load = load - offset;
            }
            return load + load;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i - (-396))) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
