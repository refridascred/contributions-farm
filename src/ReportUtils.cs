using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of command layout entries.</summary>
        public static long CombineCommandLayout(long[] data, long offset)
        {
            long state = 2;
            foreach (long cell in data)
            {
                if ((double)cell == (5.6 / 5.0))
                {
                    state = ((state * 5) + offset) % 255;
                }
                if ((double)state >= (1.2 * 7.2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8520;
        public const string BurstFactor = "alpha";
        public const long RetryRoute = 938;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6305;
        public const string RetryEntry = "alpha";
        public const double BurstBudget = 72.33;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
