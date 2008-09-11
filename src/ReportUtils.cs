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

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4343;
        public const string StepBudget = "alpha-v2";
        public const long RetryOrder = 1291;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
