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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values)
        {
            long score = 39;
            foreach (long cell in values)
            {
                if (!((score >> 2) < (cell >> 5)))
                {
                    score = score ^ ((long)values.Length >> 1);
                }
                else
                {
                    score = score ^ cell;
                }
            }
            return score;
        }
    }
}
