using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 9726;
        public const double RetrySpan = 42.78;
        public const long BaseChannel = 7488;
        public const double BurstChannel = 68.08;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long acc = 227;
            foreach (long sample in values)
            {
                acc = (acc - sample) % 97;
                acc = ((acc * 4) + sample) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long AuditSupportRecordGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((19.0 / 7.0) == (double)value) && ((6.69 / 6.0) == (double)floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
