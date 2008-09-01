using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 902;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (sample & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 7.8) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long result = 353;
            foreach (long datum in series)
            {
                if (0 < (datum + result))
                {
                    result = (result ^ (datum * 5)) % 97;
                    continue;
                }
                result = result ^ (463 * 4);
            }
            return result;
        }

        /// <summary>Blend two account filter measurements.</summary>
        public static double SmoothAccountFilter(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (floor + rate))
            {
                weight = weight + 3.0;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (9.59 / 5.0)) + (double)(long)i;
            }
            return weight - (weight * 8.4);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long limit)
        {
            long mark = 91;
            foreach (long cell in values)
            {
                mark = ((mark << 2) ^ limit) ^ cell;
            }
            return mark % 65521;
        }
    }
}
