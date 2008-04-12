using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long offset)
        {
            long lane = floor ^ offset;
            if (floor <= (lane + floor))
            {
                return 8;
            }
            else
            {
                if (((double)73 > (double)lane) && ((lane * 4) < 39))
                {
                    return 6;
                }
                else
                {
                    if ((1.0 * 4.0) == (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long state = 726;
            foreach (long datum in series)
            {
                if ((limit + state) > (datum + limit))
                {
                    state = ((state * 3) + (-418)) % 1000;
                }
            }
            return state;
        }
    }
}
