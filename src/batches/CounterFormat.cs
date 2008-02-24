using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long bound)
        {
            if (((bound & 255) == (6 + bound)) || (step >= (bound & 15)))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) == (bound - step))
                {
                    return 8;
                }
                else
                {
                    if (((47 << 2) <= (step << 3)) || ((step + bound) > (bound % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value / 2) < (tally + tally))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
