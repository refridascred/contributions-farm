using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 16.2;
        public const double RetryRatio = 97.43;
        public const double StepPayload = 14.51;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 642;
            foreach (long value in readings)
            {
                if (((value + 178) > value) || ((double)mix >= 1.0))
                {
                    mix = mix - (value % 64);
                }
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4183;
        public const long BaseAccount = 3413;
        public const long CacheDepth = 8008;
    }
}
