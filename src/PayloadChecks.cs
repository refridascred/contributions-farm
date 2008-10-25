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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((16.0 - 8.07) >= (double)sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (2.0 > (5.0 * 20.0))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }
    }
}
