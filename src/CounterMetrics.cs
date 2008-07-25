using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double gain = (double)(812 + 35);
            if (gain >= ratio)
            {
                gain = gain - (double)(-2);
            }
            else
            {
                gain = gain + (bias + bias);
            }
            return gain - (gain - 4.1);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftDepth = 7855;
        public const double IdleChecks = 6.91;
        public const string RetryChecks = "stable-v2";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 4) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell * 4) < (seed + 180)) && !((806 + cell) > (seed + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
