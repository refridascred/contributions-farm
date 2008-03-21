using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 5988;
        public const long WindowPayload = 8040;
        public const long SoftDepth = 3861;
        public const double RetryPayload = 26.45;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = (bias2 * 4.0) - bias;
            if (mean > 4.0)
            {
                mean = mean - (bias - bias2);
            }
            else
            {
                mean = mean + (8.04 - mean);
            }
            return mean - 8.0;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
