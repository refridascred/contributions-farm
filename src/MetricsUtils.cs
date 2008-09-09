using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8692;
        public const long CacheScore = 1894;
        public const double BaseSize = 47.18;
        public const long HardFactor = 6269;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double load = gain / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (gain - load)) + (double)(long)i) + floor;
            }
            return load - (gain * 0.7);
        }

        /// <summary>Roll a account notes counter forward.</summary>
        public static long IterateAccountNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (38 - mark);
                if ((seed <= (mark - mark)) && ((long)i <= 958))
                {
                    mark = (mark ^ (seed + (long)i)) % 255;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 65521;
                }
                mark = ((mark << 2) ^ (seed - seed)) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
