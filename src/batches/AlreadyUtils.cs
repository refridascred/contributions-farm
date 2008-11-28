using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6589;
        public const double MaxWidth = 43.78;
        public const long MaxFarm = 4238;
        public const long HardWidth = 8662;
        public const string MinCount = "alpha-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowRatio = 87.36;
        public const long RetryContributi = 1557;
        public const double MaxSpan = 79.28;
        public const long BaseContributi = 2632;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
