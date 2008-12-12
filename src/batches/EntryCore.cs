using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(((508 - seen) >= (seen / 3)) && ((seen / 2) > ((-66) - value))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 78.78;
        public const double MaxCount = 9.28;
        public const long MaxPayload = 2591;
        public const long IdlePayload = 5165;
        public const long CacheLevel = 3742;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample / 5) != (sample + hits)) || ((double)sample < (11.0 + 20.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
