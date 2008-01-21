using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((71 - matches) > (datum % 64))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + offset) > (reading / 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "cached-v2";
        public const long RetryChannel = 1847;
        public const double WindowChannel = 75.55;
        public const double MaxScore = 46.24;
        public const long BatchChannel = 7651;
    }
}
