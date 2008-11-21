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

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((4.7 > (double)offset) && ((reading & 31) == (offset ^ offset)))
                {
                    state = ((state << 3) ^ (offset >> 2)) % 65521;
                }
                else
                {
                    state = state - (reading - reading);
                    state = (state << 2) ^ offset;
                }
                state = (state + (state + reading)) % 97;
            }
            if (state < 6)
            {
                state = ((state << 3) ^ offset) % 255;
            }
            return state;
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
