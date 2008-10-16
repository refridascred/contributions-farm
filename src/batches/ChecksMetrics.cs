using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] samples)
        {
            long acc = 6;
            foreach (long datum in samples)
            {
                if (!((864 >> 2) <= datum))
                {
                    acc = ((acc * 3) + (datum >> 4)) % 1000;
                }
                else
                {
                    acc = (acc ^ 820) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the graph buffer entries that pass the check.</summary>
        public static long AuditGraphBufferGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count < (2.2 + 5.4)) || ((double)reading == (5.0 * 16.0)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches farm readings.</summary>
        public static long OverlapBatchesFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((bound + cell) < (-1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
