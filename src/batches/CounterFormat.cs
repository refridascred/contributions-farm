using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double mean = 9.64 - weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)157;
        }

        /// <summary>Locate a farm buffer reading by value.</summary>
        public static long LookupFarmBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            Closed,
            Locked,
            Draft,
            Retry,
        }
    }
}
