using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if ((bound < (bound + limit)) || ((limit + (-55)) == (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if ((13.0 * 5.15) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound + limit) < limit) && ((4 + limit) < 209))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 63) >= (limit + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((floor + 368) == (value / 2)) || (count > (value % 24))) && ((floor & 3) <= (count & 7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools entry series from a seed.</summary>
        public static long DeriveToolsEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total + bound)) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
