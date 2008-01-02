using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchRatio = 2629;
        public const string RetryCommits = "stable-v2";
        public const long LimitFactor = 1892;
        public const long HardTimeout = 8082;
        public const long DefaultCommits = 9422;
    }
}
