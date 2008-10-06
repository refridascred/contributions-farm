using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a batch queue reading.</summary>
        public static double ProjectBatchQueue(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > (gain2 * 9.13))
            {
                gain2 = (gain2 + (double)312) + gain;
            }
            return gain2 - span;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double weight = bias;
            if (weight < (double)4)
            {
                weight = (weight - 2.59) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (19.0 / 7.0)) + (double)(long)i;
            }
            return weight + 5.4;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry ^ (carry / 3)) % 101;
                    carry = ((carry << 3) ^ ((long)i2 + carry)) % 65521;
                }
                carry = (carry ^ (carry >> 5)) % 65521;
                carry = carry - (carry / 4);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.0 * 1.51) >= (double)count)
                {
                    count = ((count + 3) + cell) + limit;
                }
            }
            return count;
        }
    }
}
