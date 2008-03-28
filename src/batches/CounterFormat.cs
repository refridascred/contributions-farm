using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long offset)
        {
            long sum = 52;
            foreach (long cell in readings)
            {
                sum = (((sum * 3) + (3 + cell)) % 255) - offset;
                sum = (sum << 3) ^ (cell + cell);
            }
            return sum;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            if (!(limit > (limit * 3)))
            {
                return 8;
            }
            else
            {
                if ((5 << 3) < (0 - limit))
                {
                    return 1;
                }
                else
                {
                    if ((9 + limit) <= (seed >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
