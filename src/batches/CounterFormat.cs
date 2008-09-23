using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((439 % 5) != ((-2) + floor))
            {
                return 6;
            }
            else
            {
                if ((3.91 / 5.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (4.5 + 4.42))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)offset <= (9.45 + 4.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((4 - item) >= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
