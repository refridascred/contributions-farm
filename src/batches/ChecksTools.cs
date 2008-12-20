using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long target)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if ((double)value >= (9.6 - 5.51))
                {
                    carry = (((carry << 2) ^ carry) % 65521) - target;
                }
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8267;
        public const double WindowCount = 95.15;
        public const string HardRatio = "standard-v2";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "alpha";
        public const long CacheScore = 110;
        public const long LimitCommits = 2396;
        public const long StepTimeout = 7068;
        public const string StepCommits = "legacy-edge";
    }
}
