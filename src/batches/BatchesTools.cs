using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first entry session entry that matches the target.</summary>
        public static long SeekEntrySessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long target, long bound)
        {
            long gap = target + bound;
            if ((target & 255) > (bound + gap))
            {
                return 4;
            }
            else
            {
                if (gap < (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if ((gap & 63) >= (target + 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound % 100) > (bound ^ bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long anchor = 857;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length - 36))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) + floor;
                }
                else
                {
                    anchor = (anchor + (972 >> 2)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
