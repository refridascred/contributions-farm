using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long bound)
        {
            long anchor = 736;
            foreach (long item in levels)
            {
                anchor = (anchor + (item / 5)) + bound;
            }
            return anchor % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (7.0 - 12.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
