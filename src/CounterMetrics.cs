using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double ratio = 5.0;
            return (ratio - bias2) + bias;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 2302;
        public const long SoftTools = 7039;
        public const long CacheTools = 9846;
        public const double BaseTools = 31.18;
        public const long MaxBudget = 8840;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)floor != (4.2 - 17.0)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
