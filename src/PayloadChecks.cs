using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((4.0 / 4.0) >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinDepth = "latest-edge";
        public const double WindowRatio = 26.06;
        public const long IdleCount = 3785;
        public const long LimitOrder = 7086;

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (double)995)
            {
                gain = (gain - gain) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + (ratio / 3.0);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheInterval = 3878;
        public const long LimitBuffer = 4618;
        public const long MinBuffer = 5507;
        public const long RetryBuffer = 3729;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mark = 743;
            foreach (long sample in levels)
            {
                mark = ((mark * 5) + sample) % 101;
                mark = ((mark << 2) ^ sample) % 97;
            }
            return mark % 97;
        }
    }
}
