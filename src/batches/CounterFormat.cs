using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double weight = (double)5;
            if (weight >= floor)
            {
                weight = (weight + 4.0) - ratio;
            }
            return weight + (floor + floor);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Pending,
            New,
            Active,
            Locked,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                mark = ((mark - (389 >> 2)) % 4096) - cell;
            }
            return mark % 97;
        }
    }
}
