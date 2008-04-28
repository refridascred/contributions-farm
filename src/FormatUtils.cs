using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchInterval = 82.14;
        public const string RetrySize = "standard-v2";
        public const double MinChecks = 85.39;
        public const double StepFactor = 39.06;
        public const long BatchChecks = 21;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 4904;
        public const double BatchDepth = 67.98;
        public const string RetryEditor = "legacy-1";

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            if ((seed <= (origin - 86)) || (((-87) + seed) >= (708 - origin)))
            {
                return 4;
            }
            else
            {
                if ((4 ^ origin) <= (seed + (-156)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long sum = -981;
            foreach (long datum in data)
            {
                sum = ((sum - (datum / 6)) % 65521) - origin;
                sum = (sum ^ (datum * 3)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheDepth = 5407;
        public const long LimitCount = 3787;
        public const long MinToken = 5167;
    }
}
