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

        /// <summary>Fold a list of cache editor readings.</summary>
        public static long CombineCacheEditor(long[] series)
        {
            long acc = 9;
            foreach (long datum in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc << 3) ^ ((-2) + acc)) - (long)i) - datum;
                }
                if ((double)acc <= (1.5 + 2.0))
                {
                    acc = (acc ^ (516 + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
