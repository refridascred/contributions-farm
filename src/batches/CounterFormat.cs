using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally <= (double)entry) && (((entry - tally) < 553) || ((entry / 7) == (tally >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            New,
            Closed,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "legacy-edge";
        public const long BaseBudget = 6664;
        public const long HardNotes = 9892;
        public const double IdleTimeout = 51.72;
    }
}
