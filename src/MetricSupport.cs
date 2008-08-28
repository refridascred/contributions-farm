using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up layout order samples.</summary>
        public static long CompareLayoutOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long seed)
        {
            long mix = 65;
            foreach (long sample in samples)
            {
                mix = ((mix ^ (mix + seed)) % 1000) + sample;
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
