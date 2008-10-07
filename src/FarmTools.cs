using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.6 + 9.0) > (double)datum)
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long seed)
        {
            long prev = offset + seed;
            if ((seed ^ seed) > (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((offset & 63) < ((-47) + offset))
                {
                    return 3;
                }
                else
                {
                    if (seed > (seed / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + offset) > (prev >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
