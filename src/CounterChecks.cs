using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
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

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
