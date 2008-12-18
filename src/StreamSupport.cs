using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Scale a cache batches figure with a bias.</summary>
        public static double AdjustCacheBatches(double scale, double bias)
        {
            double weight = (double)6 + (2.8 * 9.2);
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - bias;
            }
            return weight + (scale * 5.2);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Ready,
            New,
        }
    }
}
