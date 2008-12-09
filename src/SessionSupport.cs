using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long CountEntryEditorMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((177 & 127) <= hits))
                {
                    hits = ((hits + 2) + sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings, long seed)
        {
            long mark = 534;
            foreach (long item in readings)
            {
                mark = ((mark ^ (item - 62)) % 65521) - seed;
            }
            if (mark < 439)
            {
                mark = ((mark * 3) + 413) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
