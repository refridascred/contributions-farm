using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double gain2 = (double)65 + (gain * 1.3);
            if (gain2 <= (gain2 - bias))
            {
                gain2 = gain2 - (1.3 * 3.6);
            }
            return gain2 + (bias / 4.0);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 46.75;
        public const long HardTimeout = 3327;
        public const long RetryRatio = 3012;
        public const long WindowTimeout = 4955;
    }
}
