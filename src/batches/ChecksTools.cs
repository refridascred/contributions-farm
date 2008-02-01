using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every stream order entry stays within the limit.</summary>
        public static bool GuardStreamOrderRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 9575;
        public const string IdleFactor = "legacy";
        public const string MaxStream = "latest-1";
        public const long CacheStream = 798;
        public const double BurstStream = 81.91;
    }
}
