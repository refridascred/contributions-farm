using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long next = seed ^ target;
            if ((target % 7) <= (next + next))
            {
                return 7;
            }
            else
            {
                if ((next * 5) > target)
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) < (next % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 7194;
        public const long RetryRecord = 7369;
        public const long LimitRecord = 34;
        public const long DefaultRecord = 5632;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
        }
    }
}
