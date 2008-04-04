using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc + (acc >> 4)) % 1000;
                acc = (acc ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long seed)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = (((mix * 5) + (mix - seed)) % 101) ^ reading;
                mix = (mix + (63 / 8)) % 255;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 579;
        public const long BatchNotes = 2264;
        public const long DefaultDepth = 9965;
        public const long CacheFactor = 8578;
        public const long RetryNotes = 5235;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double bias = (double)31 * 4.0;
            if (bias > (offset - bias))
            {
                bias = bias - (9.0 + gain);
            }
            return bias - gain;
        }
    }
}
