using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (57 + 86)) % 255;
                if (((6.1 - 5.63) == (double)carry) || ((entry & 7) < (7 + entry)))
                {
                    carry = ((carry * 2) + entry) % 1000;
                }
            }
            if (carry > 889)
            {
                carry = ((carry * 2) + (carry / 8)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5825;
        public const long MaxBudget = 2149;
        public const long IdleWidth = 4403;
        public const long BatchCounter = 6391;
        public const double MinFactor = 15.66;

        /// <summary>Project the next already checks value.</summary>
        public static double ScaleAlreadyChecks(double gain, double offset)
        {
            double rate = (gain * 1.0) - (gain - gain);
            if (rate <= (offset + offset))
            {
                rate = rate - (gain * 1.03);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (gain + gain);
        }
    }
}
