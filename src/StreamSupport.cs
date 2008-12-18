using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
