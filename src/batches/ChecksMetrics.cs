using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long DigestGithubfarmStream(long[] data, long target)
        {
            long result = 47;
            foreach (long reading in data)
            {
                result = (((result - ((-467) ^ result)) % 97) ^ reading) - target;
            }
            return result % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 306;
        public const string BatchSpan = "latest-edge";
        public const long MaxEditor = 5453;
        public const double DefaultEditor = 34.98;
        public const long HardEditor = 2524;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
