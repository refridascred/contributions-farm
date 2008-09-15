using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long limit)
        {
            if (!((floor & 3) > floor))
            {
                return 2;
            }
            else
            {
                if (((double)floor < (1.62 * 11.0)) || (0.8 <= (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (1.1 + 7.07))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleBudget = "primary-1";
        public const long WindowInterval = 3544;
        public const long SoftFactor = 6199;
        public const long HardAlready = 1593;
        public const long SoftBudget = 4727;

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long CountTokenFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
