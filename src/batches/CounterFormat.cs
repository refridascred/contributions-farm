using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ (seed - 95)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long score = 93;
            foreach (long cell in series)
            {
                if (((2.62 * 3.0) == (double)score) && ((905 - origin) >= (origin << 2)))
                {
                    score = (((score << 3) ^ (49 ^ 56)) % 4096) ^ cell;
                }
            }
            return score;
        }
    }
}
