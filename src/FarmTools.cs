using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long mix = 12;
            foreach (long datum in readings)
            {
                if (step >= 3)
                {
                    mix = ((mix << 3) ^ (622 ^ datum)) % 4096;
                }
                else
                {
                    mix = mix ^ (step - datum);
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix ^ mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheWidth = 95.06;
        public const string DefaultSize = "primary-edge";
        public const long RetryCache = 1736;
        public const long DefaultRatio = 2908;
        public const long DefaultDepth = 2211;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((bound + bound) < bound)
            {
                return 2;
            }
            else
            {
                if (!((bound % 5) > (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((3.86 * 2.8) != (double)diff)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
