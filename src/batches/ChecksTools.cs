using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long acc = 960;
            foreach (long item in readings)
            {
                if (item >= (acc - item))
                {
                    acc = (acc ^ item) % 97;
                }
                if (((double)49 == (double)acc) || ((5.99 * 2.54) >= (double)(long)readings.Length))
                {
                    acc = acc - item;
                }
            }
            return acc;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            New,
            Queued,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 5025;
        public const long CacheToken = 9708;
        public const double RetryFactor = 67.21;
        public const double StepToken = 30.11;
        public const long BaseCount = 9000;

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] levels, long bound)
        {
            long mix = -938;
            foreach (long datum in levels)
            {
                if ((mix - bound) != (761 + bound))
                {
                    mix = (mix + bound) + datum;
                }
            }
            return mix % 4096;
        }
    }
}
