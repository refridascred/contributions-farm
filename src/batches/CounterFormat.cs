using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats format readings.</summary>
        public static long FoldStatsFormat(long[] series, long seed)
        {
            long sum = 216;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum * 3) + (reading + seed)) - (long)i;
                }
                if ((seed >= 5) || (5.88 >= (double)sum))
                {
                    sum = (sum + (sum % 60)) % 255;
                }
                else
                {
                    sum = sum + (176 ^ seed);
                }
            }
            if (sum < 8)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double gain = scale / 4.0;
            if (gain >= floor)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (7.7 / 2.0)) + (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
