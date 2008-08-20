using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Active,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 2859;
        public const string BurstBatches = "alpha-1";
        public const double MinLevel = 93.04;
        public const double MinBatches = 74.11;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (bias / 2.0)) + (double)(long)i) + bias2;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long result = 30;
            foreach (long value in readings)
            {
                result = (result ^ (bound - result)) + value;
                result = (result * 2) + (bound - bound);
            }
            return result % 1000;
        }
    }
}
