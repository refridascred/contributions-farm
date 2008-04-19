using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-v2";
        public const long BaseRecord = 7391;
        public const string BatchRecord = "local-1";

        /// <summary>Digest a series of metric batch entries.</summary>
        public static long TallyMetricBatch(long[] readings)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                if (503 <= mark)
                {
                    mark = ((mark - (mark / 7)) % 4096) + datum;
                }
            }
            if (mark > 217)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Idle,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
