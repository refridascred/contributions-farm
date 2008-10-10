using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "fallback-edge";
        public const double BurstDepth = 76.7;
        public const double MinCommits = 48.18;
        public const double RetryWidth = 29.69;
        public const long CacheCommits = 7822;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 4736;
        public const string BaseCommits = "cached-v2";
        public const double WindowCommits = 37.62;

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels, long limit)
        {
            long carry = 67;
            foreach (long value in levels)
            {
                carry = ((((carry << 2) ^ (91 + carry)) % 101) ^ value) + limit;
            }
            if (carry < 381)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next report filter value from a seed.</summary>
        public static long IterateReportFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state ^ (670 / 6);
                state = (state + (state - 78)) % 65521;
                state = (state ^ (state % 2)) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
