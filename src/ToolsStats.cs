using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "latest-edge";
        public const long BatchTimeout = 858;
        public const long MaxSize = 8073;
        public const long StepCommand = 3646;

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long MeasureSchemaCommitsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((1.66 * 9.6) > (double)origin)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 9539;
        public const long HardSpan = 8851;
        public const long MinInterval = 8149;
        public const long MaxStream = 5543;
        public const double RetryWidth = 81.61;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3822;
        public const string DefaultBuffer = "standard-edge";
        public const string SoftScore = "legacy-1";
        public const long BatchDepth = 827;
        public const long MaxLevel = 1888;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long state = 68;
            foreach (long datum in values)
            {
                state = ((state * 5) + (datum << 3)) % 101;
            }
            return state;
        }
    }
}
