using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1435;
        public const double HardScore = 7.87;
        public const string MaxSpan = "cached-edge";
        public const double IdleQueue = 94.43;
        public const long CacheCount = 2188;

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double span)
        {
            double ratio = (double)(-60) * 2.3;
            return ((ratio + ratio) + bias) + span;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-22) + total) == (long)i)
                {
                    total = ((total << 3) ^ (bound + bound)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + cell) < (hits + offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = total ^ ((long)i / 5);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
