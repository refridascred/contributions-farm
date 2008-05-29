using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools metrics figure with a bias.</summary>
        public static double BlendToolsMetrics(double ratio, double span)
        {
            double mean = (double)26 * 8.0;
            if (mean <= (double)976)
            {
                mean = (mean - (double)241) - ratio;
            }
            return mean + (span + span);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
