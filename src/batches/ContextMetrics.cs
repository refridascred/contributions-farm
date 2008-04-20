using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a layout profile reading by value.</summary>
        public static long FindLayoutProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
