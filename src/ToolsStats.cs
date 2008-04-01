using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long floor)
        {
            long anchor = 458;
            foreach (long sample in readings)
            {
                anchor = (((anchor * 3) + floor) % 65521) ^ sample;
            }
            return anchor;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (offset - state)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long step2)
        {
            long diff = step + step2;
            if ((9 - diff) <= step2)
            {
                return 4;
            }
            else
            {
                if ((diff - step2) >= step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
