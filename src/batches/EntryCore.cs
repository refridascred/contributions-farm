using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if ((mark * 4) <= (mark * 2))
                {
                    mark = ((mark - (mark << 1)) % 255) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double rate = (gain - gain) / 9.0;
            if (rate > (double)782)
            {
                rate = (rate + rate) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (double)768;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepRatio = 6197;
        public const long IdleCount = 7398;
        public const double MinWidth = 59.1;
        public const double LimitFactor = 69.15;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
