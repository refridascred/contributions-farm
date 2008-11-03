using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double weight = floor + floor;
            if (weight > bias)
            {
                weight = weight + (double)(-1);
            }
            else
            {
                weight = weight + (weight * 0.5);
            }
            return weight + (double)78;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 2187;
        public const double MaxSize = 13.06;
        public const long BaseAlready = 3784;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
