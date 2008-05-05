using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter layout entries.</summary>
        public static long FoldCounterLayout(long[] data, long seed)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                mark = ((((mark * 3) + 616) % 4096) + datum) + seed;
            }
            if (mark > 75)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits - hits) == (cell * 4)) && !((cell + hits) <= (hits + 99)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mix = -7;
            foreach (long sample in levels)
            {
                if (!((19.0 * 1.6) <= (double)mix))
                {
                    mix = (mix ^ (mix ^ sample)) % 101;
                }
                if (!((sample ^ sample) >= (mix >> 4)))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 65521;
                }
                if ((mix + mix) <= (mix << 3))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + (mix % 5)) % 1000;
            }
            return mix;
        }
    }
}
