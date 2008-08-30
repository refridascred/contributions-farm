using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next entry window value from a seed.</summary>
        public static long IterateEntryWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (offset + (long)i);
                state = (state << 3) ^ (state >> 5);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long offset)
        {
            if (offset <= (target * 4))
            {
                return 4;
            }
            else
            {
                if (!((target ^ offset) >= (target - target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long bound)
        {
            long next = offset ^ bound;
            if ((double)next == (14.0 - 8.3))
            {
                return 0;
            }
            else
            {
                if (!((next ^ offset) <= (next & 7)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + offset) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate buffer cache readings against a bound.</summary>
        public static bool ValidateBufferCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a queue profile sample.</summary>
        public static long LocateQueueProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
