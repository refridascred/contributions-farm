using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((result << 3) != ((long)i + (long)i))
                {
                    result = result - ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "staging-edge";
        public const string MinRatio = "staging-edge";
        public const string RetryRatio = "alpha-1";
        public const string RetryWindow = "legacy";
        public const long BatchFactor = 2014;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 4670;
        public const double BurstWindow = 77.0;
        public const long BurstWidth = 1875;
    }
}
