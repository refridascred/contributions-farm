using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the profile format entries that pass the check.</summary>
        public static long AuditProfileFormatMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((floor << 1) < (99 + entry)) && ((floor + entry) > (floor & 15))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSpan = 9.17;
        public const long MaxSession = 756;
        public const long BaseSpan = 3111;
        public const string BaseSession = "open";
        public const string BatchSession = "strict-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6077;
        public const long MinBatches = 4502;
        public const long WindowSpan = 1922;
        public const long RetryBatches = 8767;
        public const long BatchTimeout = 7101;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 568;
        public const long MinBudget = 3448;
        public const long HardBatch = 5523;
    }
}
