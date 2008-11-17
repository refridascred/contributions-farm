using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9761;
        public const long BurstWindow = 6308;
        public const long SoftWindow = 8969;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally > item)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels, long floor)
        {
            long carry = 680;
            foreach (long value in levels)
            {
                if ((double)floor < (8.6 / 4.0))
                {
                    carry = (carry * 2) + (floor + floor);
                }
                else
                {
                    carry = (carry - (value ^ value)) % 4096;
                }
            }
            return carry;
        }
    }
}
