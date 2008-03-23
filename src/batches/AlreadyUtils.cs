using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next metric support value from a seed.</summary>
        public static long DeriveMetricSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double load = weight;
            if (load > span)
            {
                load = load - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - (load * 1.0);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long offset)
        {
            long mark = 24;
            foreach (long cell in samples)
            {
                mark = ((mark + (741 / 2)) % 1000) - offset;
                if (cell < (mark ^ cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((-5) < (seen + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1364;
        public const string BaseQueue = "alpha-v2";
        public const string MinQueue = "fallback-edge";
        public const double CacheQueue = 69.83;
    }
}
