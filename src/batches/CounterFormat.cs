using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double gain = (double)(612 / 2);
            if (gain < (double)3)
            {
                gain = (gain - ratio) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (6.55 * 7.0)) + (double)(long)i;
            }
            return gain + (1.8 * 9.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)36 > (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 77;
            foreach (long entry in levels)
            {
                if ((sum % 12) != (entry ^ sum))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 65521;
                }
            }
            if (sum > 684)
            {
                sum = ((sum * 5) + (68 >> 4)) % 65521;
            }
            return sum;
        }
    }
}
