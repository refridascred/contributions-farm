using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long CountCommandSupportHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((floor / 3) > (202 & 31)) && (floor <= datum)) || (((floor ^ hits) < hits) && (floor < ((long)levels.Length - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((bound * 5) >= bound)
                {
                    mark = (mark + (sample - mark)) % 1000;
                }
            }
            if (mark < 84)
            {
                mark = mark - (bound % 5);
            }
            return mark;
        }
    }
}
