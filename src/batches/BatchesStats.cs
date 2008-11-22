using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double load = (double)(81 + (-62));
            if (load >= (double)59)
            {
                load = (load - (load + 9.5)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 4.8) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long sum = 523;
            foreach (long sample in samples)
            {
                sum = (sum - (8 * 4)) ^ sample;
            }
            return sum;
        }
    }
}
