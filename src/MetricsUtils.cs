using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Adjust a layout batch reading.</summary>
        public static double ScaleLayoutBatch(double weight, double offset)
        {
            double gain = (double)(3 + 99);
            if (gain > weight)
            {
                gain = gain + (8.06 / 2.0);
            }
            else
            {
                gain = gain - (offset * 10.0);
            }
            return gain - (double)10;
        }

        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long StepChannelTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }
    }
}
