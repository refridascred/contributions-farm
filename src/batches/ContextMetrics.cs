using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data, long offset)
        {
            long acc = 614;
            foreach (long datum in data)
            {
                acc = (acc ^ (datum / 8)) % 4096;
                if ((datum + acc) <= offset)
                {
                    acc = (acc ^ (datum + offset)) % 65521;
                }
                else
                {
                    acc = (acc + (3 << 2)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples)
        {
            long sum = 25;
            foreach (long cell in samples)
            {
                if (!(3.2 <= (double)cell))
                {
                    sum = (sum ^ (sum % 64)) % 255;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double ratio = (double)(6 - 56);
            if (ratio >= (gain - 5.69))
            {
                ratio = ratio + (gain + bias);
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data, long step)
        {
            long carry = -822;
            foreach (long value in data)
            {
                carry = (((carry * 5) + (659 % 3)) - value) - step;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum - (long)i) % 255;
                    sum = (sum ^ ((long)i2 / 9)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
