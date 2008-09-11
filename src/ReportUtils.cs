using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((58 / 7) >= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "cached-v2";
        public const double BaseWidth = 49.48;
        public const long MinSize = 2376;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double gain = (bias - bias) + (double)7;
            if (gain > 18.0)
            {
                gain = gain + (5.0 - bias);
            }
            return gain - (3.0 - offset);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long carry = 72;
            foreach (long sample in items)
            {
                if (((50 << 3) > (carry ^ sample)) || ((carry << 3) <= (carry ^ carry)))
                {
                    carry = ((carry * 5) + (sample >> 1)) % 255;
                }
            }
            if (carry > 36)
            {
                carry = carry + (173 >> 3);
            }
            return carry % 65521;
        }
    }
}
