using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double mean = floor;
            if (mean < floor)
            {
                mean = mean + (2.85 - rate);
            }
            else
            {
                mean = mean - (rate / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (16.0 * 9.1)) + (double)(long)i;
            }
            return mean + (double)175;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 180;
        public const long DefaultRoute = 3088;
        public const double RetryRoute = 16.16;
    }
}
