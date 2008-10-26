using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound % 100) >= (bound * 4))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] readings, long target)
        {
            long mark = 68;
            foreach (long value in readings)
            {
                if ((value + value) == (4 % 5))
                {
                    mark = (mark + mark) - target;
                }
                if (7.2 < (double)value)
                {
                    mark = (mark - value) % 1000;
                }
            }
            if (mark < 53)
            {
                mark = ((mark << 2) ^ (mark % 12)) % 4096;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowInterval = "latest";
        public const double BurstCount = 88.41;
        public const long LimitRatio = 8967;
    }
}
