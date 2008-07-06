using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((target / 9) <= target) || (((target ^ entry) <= (target / 6)) && ((double)matches <= (double)target)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double load = bias * 4.6;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - 4.7;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
