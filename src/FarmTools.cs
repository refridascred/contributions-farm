using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Idle,
            New,
            Retry,
        }

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
