using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (load / 9.0)) - (double)(long)i) + weight;
            }
            return load + 9.0;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
