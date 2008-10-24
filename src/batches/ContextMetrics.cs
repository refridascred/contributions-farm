using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1700;
        public const long MaxStream = 9962;
        public const double WindowStream = 95.06;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double load = (double)1 * 6.0;
            if (load >= bias)
            {
                load = load + scale;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias / 3.0)) + (double)(long)i;
            }
            return load - (double)408;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5967;
        public const string LimitMetric = "cached-v2";
        public const string WindowMetric = "fallback";
        public const long MinDepth = 6336;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long offset, long limit)
        {
            if ((limit + limit) <= ((-236) % 8))
            {
                return 6;
            }
            else
            {
                if ((5.58 / 4.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
