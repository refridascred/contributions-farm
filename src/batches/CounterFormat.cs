using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) > seed)
                {
                    acc = (acc - (seed + acc)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the layout stream series from a seed.</summary>
        public static long IterateLayoutStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (origin & 7)) % 65521;
                anchor = ((anchor * 5) + (origin + origin)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1392;
        public const long CacheBatch = 3947;
        public const double WindowBatch = 58.34;
        public const long MinBatch = 2250;
        public const long IdleBatch = 3464;
    }
}
