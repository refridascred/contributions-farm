using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((3 + matches) >= (matches << 2))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long TallyAccountSupport(long[] samples)
        {
            long carry = -281;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry << 1)) - datum;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 7904;
        public const long CacheFarm = 172;
        public const double MaxSize = 55.11;
        public const double IdleSpan = 63.49;

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long AuditToolsReportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 2.1) != (double)count)
                {
                    count = ((count + 1) + entry) + step;
                }
            }
            return count;
        }
    }
}
