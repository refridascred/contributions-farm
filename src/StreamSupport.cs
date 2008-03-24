using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token contributi entries.</summary>
        public static long TotalTokenContributi(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                if ((state - reading) != (reading << 3))
                {
                    state = ((state * 4) + (reading ^ state)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (reading >> 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long bound, long step)
        {
            long delta = bound - step;
            if (((double)18 == (double)bound) || ((step + bound) <= (step + 9)))
            {
                return 0;
            }
            else
            {
                if ((step + bound) != (step - delta))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) < (bound % 24)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((delta < (bound + bound)) && ((double)bound >= (1.01 + 7.8)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - 2) > datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
