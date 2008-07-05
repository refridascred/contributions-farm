using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long state = -628;
            foreach (long entry in items)
            {
                state = state ^ entry;
            }
            if (state < 377)
            {
                state = (state - (state - 74)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value >= (10.0 * 16.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length >= (hits ^ hits)) || ((hits + value) == (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
