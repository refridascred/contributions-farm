using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double weight = floor;
            if (weight <= weight)
            {
                weight = (weight + 4.94) + rate;
            }
            return weight - (1.3 - 9.0);
        }

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 + 11.0) >= (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
