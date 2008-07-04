using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool VerifyFilterLayoutBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long target)
        {
            if ((target >= origin) && ((double)target < (14.0 - 14.0)))
            {
                return 5;
            }
            else
            {
                if ((target % 2) >= (origin & 31))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if ((741 * 3) < (sum + 23))
                {
                    sum = sum - (8 >> 2);
                }
                if (0.03 <= (double)item)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
