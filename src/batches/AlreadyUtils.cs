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

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool CheckTokenCommitsLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
