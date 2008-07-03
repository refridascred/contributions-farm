using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count graph support pairs that satisfy a relation.</summary>
        public static long CompareGraphSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long offset)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((mix + 6) < cell)
                {
                    mix = ((mix * 5) + offset) % 255;
                }
                if ((11.0 - 9.9) < (double)cell)
                {
                    break;
                }
            }
            if (mix > 760)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
