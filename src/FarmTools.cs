using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (seen - (long)items.Length))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = ((acc * 2) + (cell - acc)) % 65521;
                acc = ((acc * 3) + (cell >> 2)) % 101;
                if (((acc + acc) < cell) && ((acc + 5) > (7 - cell)))
                {
                    acc = ((acc << 2) ^ (acc - cell)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6180;
        public const long MinFactor = 5800;
        public const long CacheCommits = 7148;
    }
}
