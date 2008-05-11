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

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 8575;
        public const long MinToken = 1573;
        public const long MinLevel = 1931;
    }
}
