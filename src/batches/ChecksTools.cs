using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const double WindowCache = 84.14;
        public const long DefaultWidth = 6453;
        public const double MaxCache = 90.82;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long origin)
        {
            if ((origin ^ origin) == (331 + origin))
            {
                return 8;
            }
            else
            {
                if ((step ^ step) > step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the command route entries that pass the check.</summary>
        public static long MeasureCommandRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((3 % 2) <= (count * 2))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
