using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many command contributi samples are out of range.</summary>
        public static long CountCommandContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((399 + floor) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen + seen) != (seen % 16)) && ((double)seen >= 5.78))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((15.0 + 8.0) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
