using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 9985;
        public const long MaxSpan = 4556;
        public const long CacheFilter = 4374;
        public const double DefaultRatio = 9.69;
        public const long SoftDepth = 877;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry > (2.5 / 3.0)) && ((entry - hits) <= (entry ^ hits))) && ((double)hits > (5.6 + 4.23)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long TallyBatchOrderGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((39 + 556) <= ((long)readings.Length * 4)) && ((sample + seen) <= origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
