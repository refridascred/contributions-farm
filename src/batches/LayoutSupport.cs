using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples, long origin)
        {
            long acc = 403;
            foreach (long value in samples)
            {
                if (((7.6 + 2.54) > (double)origin) || (origin >= (value * 3)))
                {
                    acc = ((acc << 2) ^ (value / 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchScore = "primary-edge";
        public const string BatchCache = "local-edge";
        public const string MinCache = "open";
        public const long BaseCache = 6663;

        /// <summary>Derive the next session window value from a seed.</summary>
        public static long DeriveSessionWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 2) ^ (9 ^ seed);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
