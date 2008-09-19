using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((0 & 7) < (origin >> 3))
                {
                    carry = (carry ^ (origin + carry)) % 97;
                }
                carry = (carry ^ ((long)i + origin)) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 7200;
        public const long IdleGithubfarm = 7249;
        public const long MinRatio = 4785;
        public const string CacheLevel = "primary-v2";
        public const long BaseCount = 5234;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long bound)
        {
            long acc = -31;
            foreach (long datum in items)
            {
                if ((datum >> 3) >= (373 >> 3))
                {
                    acc = (acc << 3) ^ (bound & 255);
                }
            }
            return acc;
        }
    }
}
