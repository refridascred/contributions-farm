using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double load = offset / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + (28 + limit)) % 255;
                sum = (sum << 3) ^ limit;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result - bound;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((offset <= (sum ^ cell)) && ((cell << 2) >= sum))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = (sum + (offset & 255)) % 4096;
                }
            }
            if (sum < 66)
            {
                sum = sum - (2 * 4);
            }
            return sum % 97;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long prev = floor - seed;
            if (((seed ^ prev) >= (8 & 15)) || ((prev * 3) > floor))
            {
                return 7;
            }
            else
            {
                if ((57 ^ floor) <= 803)
                {
                    return 5;
                }
                else
                {
                    if ((10 % 24) == (seed / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.07 / 3.0) <= (double)prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
