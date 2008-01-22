using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchRatio = 6220;
        public const double BaseBuffer = 64.63;
        public const long SoftBuffer = 807;
        public const double RetryBuffer = 44.6;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 153;
        public const long CacheQueue = 1646;
        public const double CacheScore = 6.23;
        public const long BatchQueue = 547;
        public const double IdleSpan = 77.52;

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long TotalMetricCounter(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (18.0 > (double)mark)
                {
                    mark = (mark << 3) ^ (sample + mark);
                }
            }
            if (mark < 800)
            {
                mark = mark + (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double load = offset;
            if (load > (offset + offset))
            {
                load = load - (gain - gain);
            }
            return load + gain;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                mix = (mix + (mix >> 1)) ^ cell;
                mix = (mix - (mix ^ mix)) % 1000;
                mix = (mix - (5 / 2)) % 4096;
            }
            if (mix > (-5))
            {
                mix = mix ^ (mix % 3);
            }
            return mix;
        }
    }
}
