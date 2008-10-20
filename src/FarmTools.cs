using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 2) == (seed / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long TallyFilterProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((double)seen <= (3.53 + 4.9)) && ((909 + seen) <= (seen * 4))) || ((895 >> 1) <= seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
