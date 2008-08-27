using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings)
        {
            long carry = 121;
            foreach (long item in readings)
            {
                carry = carry + (item + item);
                if ((carry - carry) < (29 + item))
                {
                    carry = ((carry * 3) + (carry + 638)) % 1000;
                }
                if (6.6 <= (double)item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double mean = gain;
            if (mean < (bias + mean))
            {
                mean = mean - (bias / 8.0);
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + mean;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardBudget = "legacy-v2";
        public const long MaxMetrics = 4097;
        public const long BaseScore = 9717;
        public const double BurstMetrics = 33.29;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples, long offset)
        {
            long total = 2;
            foreach (long item in samples)
            {
                total = ((total + offset) % 101) - item;
            }
            if (total < 387)
            {
                total = (total + (offset + offset)) % 65521;
            }
            return total;
        }
    }
}
