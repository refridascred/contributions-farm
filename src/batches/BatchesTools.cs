using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long limit)
        {
            long next = bound ^ limit;
            if (bound < 81)
            {
                return 1;
            }
            else
            {
                if (bound > (21 / 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound < (1.42 + 5.0)) && ((double)limit == (double)69))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((27 - next) >= (1 * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats profile entries.</summary>
        public static long WeighStatsProfile(long[] items, long floor)
        {
            long state = -1;
            foreach (long reading in items)
            {
                state = ((state ^ state) % 4096) - floor;
                state = (state + reading) % 255;
            }
            if (state > 650)
            {
                state = (state * 2) + (state + state);
            }
            return state % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Failed,
            Draft,
        }
    }
}
