using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstCount = 68.33;
        public const double BurstMetric = 96.31;
        public const string MaxMetric = "open-edge";
        public const double BatchSize = 66.47;
        public const long LimitDepth = 4440;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches ^ entry) <= (22 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) - gain;
            }
            return rate - (double)618;
        }
    }
}
