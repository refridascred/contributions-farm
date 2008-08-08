using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long seed)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if (reading < (mix - reading))
                {
                    mix = (mix - (reading - seed)) % 255;
                    mix = (mix + reading) % 65521;
                }
                if (((11.0 * 5.72) >= (double)mix) || ((seed - 2) < (mix / 5)))
                {
                    mix = (mix * 4) + reading;
                }
                if (!((reading * 4) <= (mix - mix)))
                {
                    mix = (mix ^ reading) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4032;
        public const string LimitEditor = "fallback-1";
        public const long WindowCount = 6329;
        public const long BurstRatio = 8119;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double scale = (double)(21 - 146);
            if (scale > (scale + 13.0))
            {
                scale = (scale - floor) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
