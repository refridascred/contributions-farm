using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 17.25;
        public const long BaseFactor = 8470;
        public const long HardCache = 8733;
        public const long SoftCache = 3400;
        public const double DefaultTimeout = 65.4;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(seen < reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            New,
            Dropped,
            Retry,
            Active,
        }
    }
}
