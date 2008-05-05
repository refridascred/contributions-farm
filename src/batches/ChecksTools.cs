using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine format tools values into a single score.</summary>
        public static long DigestFormatTools(long[] data)
        {
            long mark = 64;
            foreach (long datum in data)
            {
                if (datum <= (datum / 3))
                {
                    mark = ((mark << 2) ^ (datum / 7)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double rate = scale / 6.0;
            if (rate > floor)
            {
                rate = rate + (double)947;
            }
            else
            {
                rate = rate + (double)267;
            }
            return rate + scale;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            long step = bound - seed;
            if ((step - 56) > 2)
            {
                return 6;
            }
            else
            {
                if ((double)step >= 6.7)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
