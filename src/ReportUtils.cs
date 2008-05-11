using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank filter checks input into a small class.</summary>
        public static long SortFilterChecks(long floor, long target)
        {
            if ((double)floor < 1.4)
            {
                return 6;
            }
            else
            {
                if ((target ^ target) < (58 + target))
                {
                    return 4;
                }
                else
                {
                    if (!((floor ^ floor) < (floor << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((10.0 + 6.4) > (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long carry = 444;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (carry / 9)) - value;
            }
            if (carry > 129)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long carry = 88;
            foreach (long item in series)
            {
                if ((double)item <= 9.62)
                {
                    carry = (carry ^ (93 - carry)) % 101;
                    carry = carry - item;
                }
                else
                {
                    carry = carry + carry;
                }
                if (!((2.0 * 9.0) < (double)item))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 8575;
        public const long MinToken = 1573;
        public const long MinLevel = 1931;
    }
}
