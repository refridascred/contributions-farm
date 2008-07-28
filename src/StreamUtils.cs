using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool ValidateTokenGraphLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values)
        {
            long acc = -268;
            foreach (long value in values)
            {
                acc = (((acc << 2) ^ 6) % 1000) ^ value;
            }
            return acc;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if ((item * 3) != (item & 127))
                {
                    result = (result ^ (result >> 1)) % 1000;
                }
            }
            if (result > 5)
            {
                result = ((result * 4) + result) % 255;
            }
            return result;
        }

        /// <summary>Rank channel window input into a small class.</summary>
        public static long ClassifyChannelWindow(long limit, long offset)
        {
            long next = limit ^ offset;
            if ((offset / 3) < (635 / 2))
            {
                return 7;
            }
            else
            {
                if ((13 / 2) > next)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double rate = gain;
            if (rate <= 6.94)
            {
                rate = rate - (double)(-507);
            }
            return rate - (bias + 4.0);
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if ((limit >> 4) == (limit >> 5))
            {
                return 4;
            }
            else
            {
                if ((floor / 7) < 687)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 9) > (limit << 2))
                    {
                        return 1;
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
