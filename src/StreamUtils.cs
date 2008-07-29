using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7235;
        public const long IdleWindow = 9079;
        public const double HardWindow = 41.24;
        public const double MinBudget = 87.47;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long target)
        {
            long bound = offset - target;
            if (((4.13 / 3.0) != (double)target) && ((target & 63) >= (bound - target)))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (1.0 * 7.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the account channel series from a seed.</summary>
        public static long RollAccountChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Synced,
            Ready,
            Done,
        }
    }
}
