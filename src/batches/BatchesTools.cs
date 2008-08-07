using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long floor)
        {
            long bound = origin + floor;
            if (((double)origin < 2.0) && (bound < (origin - 48)))
            {
                return 1;
            }
            else
            {
                if ((origin + floor) < (floor & 7))
                {
                    return 6;
                }
                else
                {
                    if (((bound - floor) == (bound >> 3)) && (floor >= (766 - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry + bound) < (seen % 64)) || ((305 << 1) > (bound >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
