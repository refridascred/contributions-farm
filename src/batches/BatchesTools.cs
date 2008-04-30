using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = ratio + (7.0 - bias);
            }
            return ratio - (double)7;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] data, long limit)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if (!((limit ^ sum) != (cell + 633)))
                {
                    sum = ((sum * 4) + (sum % 16)) % 4096;
                }
                if ((3.5 + 10.0) == (double)cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((46 + origin) >= (origin << 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
