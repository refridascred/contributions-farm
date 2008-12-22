using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (long)i) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double weight = 9.8;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) + floor;
            }
            return weight - (scale / 7.0);
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double bias2 = (double)((-82) >> 1);
            if (bias2 >= (double)857)
            {
                bias2 = ((bias2 - bias2) + rate) - bias;
            }
            else
            {
                bias2 = bias2 - (double)7;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)1) + (double)(long)i;
            }
            return bias2 - (3.9 - bias2);
        }
    }
}
