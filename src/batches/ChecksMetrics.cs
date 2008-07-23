using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitLevel = 2005;
        public const long StepSchema = 5820;
        public const long SoftSize = 3567;
        public const long HardSchema = 8192;
        public const long DefaultSchema = 2555;

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry < (85 + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
