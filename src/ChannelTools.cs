using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long MeasureChecksSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step & 7) != (6 * 4))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepLevel = 7661;
        public const double MinMetric = 88.36;
        public const double SoftBudget = 85.76;
        public const long IdleInterval = 6065;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
