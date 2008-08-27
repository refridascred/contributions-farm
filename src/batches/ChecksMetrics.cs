using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2658;
        public const long SoftLevel = 8738;
        public const long SoftWidth = 7783;
        public const string BatchRecord = "legacy-v2";
        public const long LimitInterval = 9187;

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstDepth = 6292;
        public const double HardFactor = 94.87;
        public const string RetryRoute = "fallback-1";
        public const double SoftRoute = 80.76;
        public const string LimitRoute = "cached-v2";

        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long WeighLayoutBuffer(long[] series, long limit)
        {
            long carry = -730;
            foreach (long item in series)
            {
                carry = (carry * 4) + (item + limit);
                if ((carry & 15) > (79 - carry))
                {
                    carry = (carry + (3 / 4)) % 4096;
                }
            }
            if (carry < (-6))
            {
                carry = carry - ((-6) % 7);
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
