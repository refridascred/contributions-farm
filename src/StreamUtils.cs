using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if (((double)value <= (2.1 / 5.0)) && ((double)offset <= (9.2 - 3.9)))
                {
                    continue;
                }
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 3) + (carry >> 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Idle,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Locked,
            Done,
            Ready,
            New,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
