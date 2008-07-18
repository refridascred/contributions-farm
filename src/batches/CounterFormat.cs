using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            if ((double)floor < (double)332)
            {
                return 2;
            }
            else
            {
                if (7.0 <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double bias)
        {
            double scale = (2.55 / 6.0) + 2.1;
            if (scale <= bias)
            {
                scale = scale + (3.98 - rate);
            }
            return scale + (double)4;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if (4.65 > (double)value)
                {
                    score = (score + (value >> 2)) % 97;
                    score = (score << 3) ^ (-610);
                    break;
                }
                score = ((score << 3) ^ (score + score)) % 255;
            }
            if (score < 571)
            {
                score = score - (score / 8);
            }
            return score;
        }
    }
}
