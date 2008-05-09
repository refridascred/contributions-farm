using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every stream notes entry stays within the limit.</summary>
        public static bool GuardStreamNotesRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            if (!((1.1 * 9.4) != (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleBudget = 5025;
        public const long MinBudget = 7137;
        public const long RetryBudget = 4587;
        public const long IdleFilter = 8130;
        public const long HardFilter = 5483;
    }
}
