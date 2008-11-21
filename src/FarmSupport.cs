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

        /// <summary>Count the channel already entries that pass the check.</summary>
        public static long AuditChannelAlreadyGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - bound) >= bound)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
