using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long MeasureMetricAccountOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((hits - entry) < (hits << 1)) && ((4 & 15) <= (hits - hits))) && (hits > (entry - 88)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstLevel = 7405;
        public const long DefaultSchema = 517;
        public const long DefaultRatio = 3422;
        public const long WindowWidth = 537;
        public const long HardFactor = 2410;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (score << 3)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
