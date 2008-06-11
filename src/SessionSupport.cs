using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long TallySessionContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((hits + entry) == (127 ^ hits)) || ((entry << 3) == (entry & 127)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
