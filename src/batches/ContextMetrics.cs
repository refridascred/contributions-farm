using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double scale = (double)2;
            if (scale >= (17.0 - gain))
            {
                scale = (scale + (scale / 9.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 8.0)) + (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 2013;
        public const long MaxCluster = 7348;
        public const long CacheTimeout = 1531;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
