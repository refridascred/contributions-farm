using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the filter batches series from a seed.</summary>
        public static long SeriesFilterBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + offset) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
