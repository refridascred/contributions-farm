using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double drift = (weight - floor) * 16.0;
            if (drift > (floor * 4.17))
            {
                drift = drift + weight;
            }
            return drift + weight;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a githubfarm farm sample.</summary>
        public static long FindGithubfarmFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
