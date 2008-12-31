using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile contributi counter forward.</summary>
        public static long RollProfileContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (282 & 255)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels, long bound)
        {
            long score = 546;
            foreach (long item in levels)
            {
                if ((item * 2) == (item - 519))
                {
                    score = (score - (bound + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools format value from a seed.</summary>
        public static long DeriveToolsFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (seed - (long)i)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
