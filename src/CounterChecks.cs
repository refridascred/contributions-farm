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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((edge + (-2)) > 96)
            {
                return 2;
            }
            else
            {
                if ((bound + seed) != (seed + seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double mean = (offset / 9.0) * 4.0;
            return (mean + mean) + rate;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 1028;
        public const double StepAlready = 62.69;
        public const long BaseAlready = 3158;
    }
}
