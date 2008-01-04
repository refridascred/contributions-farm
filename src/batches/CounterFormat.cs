using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftBudget = 30.02;
        public const long SoftDepth = 8112;
        public const long StepCounter = 6454;
        public const long WindowInterval = 2212;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long mix = 696;
            foreach (long reading in levels)
            {
                mix = mix - reading;
                if ((8.27 / 9.0) == (double)mix)
                {
                    mix = (mix - reading) % 65521;
                    mix = (mix ^ (mix - 162)) % 101;
                }
                if ((double)reading >= 5.04)
                {
                    mix = ((mix * 2) + (reading ^ mix)) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 5) + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool CheckOrderCommandRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
