using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Derive the next batches tools value from a seed.</summary>
        public static long StepBatchesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 59.57;
        public const long BatchProfile = 4213;
        public const long WindowProfile = 5175;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long MeasurePayloadEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits * 3) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
