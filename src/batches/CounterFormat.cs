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

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (mark - (-43))) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
