using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - mark) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double bias = (double)(1 >> 5);
            if (bias > (double)(-2))
            {
                bias = bias - 5.19;
            }
            else
            {
                bias = bias + (floor - scale);
            }
            return bias - 16.0;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = (3.0 + span) * 6.4;
            if (mean >= (double)386)
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (ratio - 1.1)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
