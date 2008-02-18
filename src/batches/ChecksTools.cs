using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double load = (bias + bias) / 8.0;
            if (load > gain)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (load - gain);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (offset << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8743;
        public const double BatchEntry = 57.71;
        public const string WindowInterval = "open";

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double bias = (span * 3.0) / 2.0;
            if (bias < 8.0)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - 10.0;
        }
    }
}
