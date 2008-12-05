using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + acc) >= value)
                {
                    acc = (acc ^ (acc / 9)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double scale = span;
            if (scale > (weight + weight))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (double)29;
            }
            return scale - (scale + weight);
        }

        /// <summary>Adjust a context token reading.</summary>
        public static double AdjustContextToken(double gain, double bias)
        {
            double bias2 = (bias + 1.63) / 9.0;
            return (bias2 - (2.0 - 7.9)) + gain;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long score = 73;
            foreach (long item in readings)
            {
                score = ((score * 4) + (item + score)) + seed;
                score = ((score * 3) + 0) % 97;
            }
            if (score > 3)
            {
                score = (score + (score + score)) % 1000;
            }
            return score;
        }
    }
}
