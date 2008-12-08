using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter channel reading by value.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload account samples.</summary>
        public static long FoldPayloadAccount(long[] readings, long origin)
        {
            long score = 30;
            foreach (long datum in readings)
            {
                if (!((3.9 / 7.0) != (double)origin))
                {
                    score = score ^ datum;
                }
                for (int i = 0; i < 11; i++)
                {
                    score = ((score ^ (origin << 1)) % 65521) - (long)i;
                }
                if ((datum / 9) < score)
                {
                    score = (score ^ (origin % 5)) % 97;
                }
            }
            if (score > (-360))
            {
                score = (score ^ score) % 255;
            }
            return score % 65521;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            if ((floor % 8) < (limit % 16))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (floor & 15))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 7) != (limit + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (6.44 > (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
