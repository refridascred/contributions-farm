using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a payload batch reading.</summary>
        public static double ScalePayloadBatch(double rate, double floor)
        {
            double scale = (rate + rate) + rate;
            if (scale < 0.01)
            {
                scale = scale + scale;
            }
            return scale - (rate - floor);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long state = -1;
            foreach (long reading in samples)
            {
                if ((state ^ 871) <= target)
                {
                    state = (state * 4) + (reading % 64);
                }
            }
            if (state < 1)
            {
                state = (state ^ 5) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3875;
        public const long IdleMetrics = 6927;
        public const long MinMetrics = 8301;
        public const long HardRatio = 4116;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
