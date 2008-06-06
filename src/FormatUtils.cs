using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double rate = ratio;
            return (rate - (ratio - rate)) + span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mix == (5.58 - 6.6))
                {
                    mix = (mix * 5) + ((long)i << 1);
                    mix = mix ^ (98 + (long)i);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "alpha-v2";
        public const double IdleEntry = 93.35;
        public const long MaxEntry = 7738;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long WeighContributiCounter(long[] values, long bound)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                if (((mark + sample) <= bound) || ((sample & 7) > (0 + bound)))
                {
                    mark = ((mark * 5) + (sample << 2)) % 4096;
                }
            }
            return mark;
        }
    }
}
