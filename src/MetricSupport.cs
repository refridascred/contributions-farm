using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 2) < (hits << 1))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches != (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
