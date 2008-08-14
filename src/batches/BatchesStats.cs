using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 89;
            foreach (long value in data)
            {
                state = ((state * 4) + 3) % 101;
                state = state - (value + value);
            }
            if (state < 90)
            {
                state = state - state;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values)
        {
            long mix = 32;
            foreach (long cell in values)
            {
                mix = mix + cell;
                if (((double)cell < (9.58 - 2.99)) && ((928 + 68) != (mix + 53)))
                {
                    mix = (mix * 4) + cell;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                acc = ((acc << 3) ^ (entry - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
