using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit record token readings against a rule.</summary>
        public static long CountRecordTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen >= (9.2 * 3.93))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinRatio = "alpha";
        public const string WindowFilter = "open-edge";
        public const long RetrySize = 3662;
        public const double RetryFilter = 82.76;
        public const long LimitCount = 1524;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)offset != (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Done,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long offset)
        {
            long acc = -81;
            foreach (long item in samples)
            {
                if ((acc - 92) > item)
                {
                    acc = ((acc ^ item) % 101) + offset;
                }
            }
            return acc;
        }
    }
}
