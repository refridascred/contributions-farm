using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double load = bias;
            return (load + load) + rate;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((origin * 3) >= (origin + origin)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
