using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            long gap = bound ^ target;
            if ((double)bound <= (double)gap)
            {
                return 7;
            }
            else
            {
                if ((target << 2) <= gap)
                {
                    return 1;
                }
                else
                {
                    if ((3.9 * 7.04) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - gap) <= (gap + gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix << 3) ^ mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
