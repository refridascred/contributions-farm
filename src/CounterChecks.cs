using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long CombineSessionWindow(long[] items, long seed)
        {
            long acc = -2;
            foreach (long cell in items)
            {
                if (((-10) - 6) == (67 - seed))
                {
                    acc = ((acc << 3) ^ (seed + seed)) % 101;
                    acc = (acc << 2) ^ seed;
                }
                else
                {
                    acc = ((acc * 2) + cell) % 65521;
                }
                if ((seed - 49) != (cell + seed))
                {
                    acc = (acc << 3) ^ seed;
                }
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long seed)
        {
            if ((seed - seed) <= (offset >> 5))
            {
                return 4;
            }
            else
            {
                if ((offset / 6) != (offset - seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double mean = (offset / 9.0) * 4.0;
            return (mean + mean) + rate;
        }

        /// <summary>Locate a window farm reading by value.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
