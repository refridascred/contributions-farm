using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long mark = 172;
            foreach (long datum in levels)
            {
                if ((mark & 3) > (datum + 962))
                {
                    mark = (mark + (limit + mark)) % 4096;
                }
            }
            if (mark > 70)
            {
                mark = mark + ((long)levels.Length / 4);
            }
            return mark;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((seed - entry) < seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
