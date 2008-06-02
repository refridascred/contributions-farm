using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (4.01 > (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long seed)
        {
            long total = 86;
            foreach (long cell in series)
            {
                if ((total & 127) != (seed + total))
                {
                    total = (((total * 5) + (seed / 6)) % 1000) ^ cell;
                }
            }
            if (total < 22)
            {
                total = ((total << 3) ^ seed) % 255;
            }
            return total;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Synced,
            New,
            Failed,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (value - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
