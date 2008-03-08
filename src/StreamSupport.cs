using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftFactor = 7898;
        public const double BaseWidth = 1.58;
        public const double RetryRatio = 0.48;
        public const long MaxBudget = 9025;
        public const string CacheCommits = "latest-edge";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long target)
        {
            if ((seed + target) >= (target - target))
            {
                return 0;
            }
            else
            {
                if (target > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((887 / 4) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
