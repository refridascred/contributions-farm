using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((count / 3) > 85))
                {
                    count = ((count + 1) - cell) - step;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 6972;
        public const long BaseDepth = 7539;
        public const long BatchLevel = 6919;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardSpan = 7361;
        public const double RetryCounter = 4.27;
        public const string StepBudget = "local-edge";
        public const double DefaultCounter = 88.97;
        public const long MaxCount = 8530;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
