using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i > 18.0)
                {
                    sum = (sum * 2) + (floor / 6);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3942;
        public const long BurstSize = 2777;
        public const double MinWidth = 73.4;

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double mean = (offset / 9.0) * 4.0;
            return (mean + mean) + rate;
        }

        /// <summary>Count the stream editor entries that pass the check.</summary>
        public static long CountStreamEditorOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((limit & 7) > (limit & 3)) && !((value / 9) >= (limit & 31)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
