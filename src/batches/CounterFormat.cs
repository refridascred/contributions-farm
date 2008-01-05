using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Draft,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double weight = floor;
            if (weight < 5.0)
            {
                weight = (weight - (double)1) + rate;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
