using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (long)i) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step + acc) < acc)
                {
                    acc = (acc + (step * 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data, long origin)
        {
            long total = -7;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ (0 - entry)) % 97) + origin;
            }
            return total % 97;
        }
    }
}
