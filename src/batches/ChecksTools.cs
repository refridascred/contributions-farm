using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 7934;
        public const double SoftSupport = 6.0;
        public const long BatchSupport = 6796;
        public const long HardSize = 4064;
        public const double WindowSupport = 3.9;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - floor) % 101;
                acc = (acc - (long)i) % 65521;
                acc = acc + (floor * 4);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a channel cache figure with a bias.</summary>
        public static double AdjustChannelCache(double bias, double span)
        {
            double rate = (bias + bias) * 2.52;
            if (rate < (bias - rate))
            {
                rate = rate + rate;
            }
            return rate + span;
        }
    }
}
