using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 825;
            foreach (long cell in data)
            {
                state = ((state - (state * 3)) % 255) ^ cell;
                if ((state % 12) == (95 - state))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (state >> 2)) % 4096;
                }
            }
            if (state > (-645))
            {
                state = (state << 2) ^ state;
            }
            return state;
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
