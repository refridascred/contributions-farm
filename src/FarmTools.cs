using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long AuditStatsCacheHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((61 + count) > count)
                {
                    count = ((count + 1) ^ datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + value) >= seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
