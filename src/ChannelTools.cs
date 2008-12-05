using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next record cache value.</summary>
        public static double SmoothRecordCache(double ratio, double floor)
        {
            double gain = (double)640 + (floor - 5.6);
            if (gain > floor)
            {
                gain = (gain + gain) + ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain * 6.7)) + (double)(long)i;
            }
            return gain + (double)46;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3182;
        public const double WindowFilter = 28.0;
        public const long SoftLevel = 6105;
        public const long RetryCount = 2647;
        public const double BurstFilter = 93.3;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
