using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long CombineNotesFarm(long[] data)
        {
            long mark = 14;
            foreach (long item in data)
            {
                mark = (mark + 626) + item;
                mark = (mark - (mark + 452)) % 1000;
            }
            if (mark > 42)
            {
                mark = ((mark << 2) ^ (mark << 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((hits >> 5) <= floor) || ((12.0 / 2.0) == (double)floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
