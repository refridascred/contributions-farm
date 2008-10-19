using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits & 255) > (datum - (-88)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long result = 169;
            foreach (long reading in levels)
            {
                if (seed <= result)
                {
                    result = (result << 3) ^ (seed - reading);
                }
                if ((result * 3) <= (seed - reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (mix - mix)) % 65521;
                if (!((291 > mix) || (mix < (mix & 3))))
                {
                    mix = mix - (8 + 65);
                    mix = (mix ^ (mix - 600)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 5292;
        public const long BaseStream = 5778;
        public const double DefaultStream = 74.36;
        public const long RetryCount = 112;
    }
}
