using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
