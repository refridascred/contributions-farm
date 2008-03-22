using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 78.06;
        public const long WindowTimeout = 8712;
        public const double WindowGraph = 21.36;
        public const string BatchInterval = "stable-v2";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor - limit) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 33;
            foreach (long cell in samples)
            {
                if ((carry ^ cell) != (645 * 5))
                {
                    carry = ((carry << 3) ^ cell) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
