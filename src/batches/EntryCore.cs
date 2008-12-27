using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((0.26 / 4.0) < (double)sample) && (((8 + hits) <= (412 + hits)) || ((hits + sample) <= (sample << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value >= (value << 3))
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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context account entries that pass the check.</summary>
        public static long AuditContextAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + (-7)) == (item & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
