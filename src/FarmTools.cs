using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 939;
        public const double DefaultCounter = 26.64;
        public const long IdleCounter = 3424;
        public const long DefaultInterval = 8201;
        public const long MaxCounter = 6634;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double mean = (double)(63 * 5);
            if (mean > (span + rate))
            {
                mean = mean - (double)858;
            }
            else
            {
                mean = mean - (double)(-811);
            }
            return mean + mean;
        }
    }
}
