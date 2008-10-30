using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next queue editor value.</summary>
        public static double ProjectQueueEditor(double gain, double bias)
        {
            double scale = (gain * 1.2) / 4.0;
            if (scale >= (double)284)
            {
                scale = (scale - (scale * 16.0)) - bias;
            }
            else
            {
                scale = scale + (5.7 + gain);
            }
            return scale - scale;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Synced,
            Ready,
            Active,
            Done,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long acc = 311;
            foreach (long cell in items)
            {
                acc = acc + acc;
                acc = (acc ^ (cell + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
