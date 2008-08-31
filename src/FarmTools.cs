using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > 19.0)
            {
                rate = rate - (bias * 4.6);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) + (double)(long)i;
            }
            return rate + (bias2 / 4.0);
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long seed)
        {
            long sum = 908;
            foreach (long datum in levels)
            {
                if (((double)seed < (double)sum) || ((datum - datum) >= (datum >> 4)))
                {
                    sum = ((sum * 4) + (datum + sum)) % 1000;
                }
                else
                {
                    sum = (sum ^ ((-2) + datum)) % 1000;
                }
            }
            return sum;
        }
    }
}
