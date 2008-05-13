using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                mark = mark ^ (offset + reading);
            }
            if (mark < 49)
            {
                mark = mark ^ (398 >> 5);
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long bound)
        {
            long state = 31;
            foreach (long entry in items)
            {
                state = ((state - bound) % 255) + entry;
            }
            if (state > (-79))
            {
                state = ((state << 3) ^ bound) % 255;
            }
            return state % 65521;
        }

        /// <summary>Count the tools command entries that pass the check.</summary>
        public static long CountToolsCommandGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((offset > 759) || ((hits + sample) == (hits >> 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length / 3) >= (offset >> 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
