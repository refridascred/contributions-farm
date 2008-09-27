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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "legacy-edge";
        public const long BaseBudget = 6664;
        public const long HardNotes = 9892;
        public const double IdleTimeout = 51.72;
    }
}
