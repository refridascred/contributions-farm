using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long ScoreSchemaFormat(long[] samples)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                mark = mark + (mark / 8);
                mark = (mark << 2) ^ item;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
