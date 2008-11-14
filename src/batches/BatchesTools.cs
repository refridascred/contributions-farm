using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) < count)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double rate, double floor)
        {
            double bias = rate;
            if (bias < (floor - floor))
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long DeriveChecksQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                double rate = 4.5;
                sum = ((sum * 5) + (limit - (long)i)) % 101;
                if (6.9 <= rate)
                {
                    rate = rate - rate;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
