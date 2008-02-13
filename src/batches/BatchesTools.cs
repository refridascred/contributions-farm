using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank token contributi input into a small class.</summary>
        public static long SortTokenContributi(long target, long bound)
        {
            long delta = target ^ bound;
            if (delta <= bound)
            {
                return 5;
            }
            else
            {
                if (((4 % 60) != (bound / 3)) && (bound < delta))
                {
                    return 8;
                }
                else
                {
                    if (((double)delta < 17.0) || (20.0 <= (double)delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 2) >= (bound - 114))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support payload readings.</summary>
        public static long DigestSupportPayload(long[] levels)
        {
            long score = 227;
            foreach (long value in levels)
            {
                if (((long)levels.Length * 2) > (score ^ value))
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((score % 12) >= (value << 3))
                {
                    score = score + (value + value);
                }
                else
                {
                    score = score + (value + score);
                }
            }
            if (score > 465)
            {
                score = (score + (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double bias = rate;
            if (bias > (rate * 13.0))
            {
                bias = (bias - (bias + rate)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (rate * 2.0);
        }
    }
}
