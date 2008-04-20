using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long total = -15;
            foreach (long sample in readings)
            {
                if (!((total % 12) > total))
                {
                    total = total - total;
                }
                else
                {
                    total = (total - (sample / 3)) % 1000;
                }
                if ((total >> 5) >= (sample << 1))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
