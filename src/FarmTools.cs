using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 1.7) - (double)(long)i;
            }
            return mean - (bias - ratio);
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
