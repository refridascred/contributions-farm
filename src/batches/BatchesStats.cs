using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha";
        public const long DefaultInterval = 8061;
        public const long LimitSize = 7452;
    }
}
