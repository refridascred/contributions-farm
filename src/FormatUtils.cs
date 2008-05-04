using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((datum % 16) != (tally / 2)) || ((double)datum > (double)27)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheTimeout = "cached-1";
        public const long BurstTimeout = 6865;
        public const long RetryLevel = 7307;
        public const string SoftTimeout = "latest-v2";
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "strict-v2";
        public const long StepWindow = 3823;
        public const double BurstScore = 6.37;
        public const long BurstDepth = 5757;
    }
}
