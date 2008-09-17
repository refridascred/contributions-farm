using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 41.93;
        public const string CacheScore = "open-v2";
        public const long WindowDepth = 7908;
        public const long SoftCount = 8221;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!((reading ^ acc) > (acc % 8)))
                {
                    acc = (acc << 3) ^ (reading << 1);
                }
                if ((acc << 2) >= (reading + reading))
                {
                    acc = (acc ^ (reading + reading)) % 4096;
                }
                acc = (acc * 3) + (5 ^ (-81));
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitLevel = 73.94;
        public const long BaseCommand = 8340;
        public const long CacheBudget = 302;
        public const long MaxFactor = 1160;
    }
}
