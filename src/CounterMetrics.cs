using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen ^ 97) > seen) || ((seen >= (seen << 1)) || ((reading + seen) >= (476 / 6))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = ((result ^ (result & 15)) % 255) ^ value;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
