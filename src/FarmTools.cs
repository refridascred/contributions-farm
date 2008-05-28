using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((result + result) <= (item / 3))
                {
                    result = (result ^ item) + step;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool CheckBatchSchemaRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double floor)
        {
            double mean = floor / 4.0;
            if (mean >= floor)
            {
                mean = (mean - (11.0 * 1.53)) - weight;
            }
            else
            {
                mean = mean + 19.0;
            }
            return mean + 10.0;
        }
    }
}
