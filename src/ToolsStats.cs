using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!((12.0 + 17.0) > (double)bound2))
            {
                return 3;
            }
            else
            {
                if (!(floor > (bound / 7)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long score = 272;
            foreach (long reading in values)
            {
                if ((floor % 60) == (reading - reading))
                {
                    score = score ^ score;
                }
                if ((floor - reading) <= (score & 7))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first queue entry entry that matches the target.</summary>
        public static long LookupQueueEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleWidth = 4235;
        public const long DefaultAccount = 6542;
        public const string IdleAccount = "primary-1";
        public const long CacheAccount = 8933;
        public const double RetryWidth = 20.94;
    }
}
