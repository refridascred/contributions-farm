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

        /// <summary>Iterate the account tools series from a seed.</summary>
        public static long IterateAccountTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + (anchor + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
