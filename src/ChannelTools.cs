using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long floor)
        {
            if (((floor >> 2) != (floor & 127)) || ((floor - floor) == (target & 255)))
            {
                return 7;
            }
            else
            {
                if ((target * 3) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double rate = 1.0 - bias;
            if (rate <= (bias * 8.7))
            {
                rate = rate - 5.63;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (offset + bias)) + (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long sum = 205;
            foreach (long reading in values)
            {
                if (((reading + (-354)) > (sum ^ reading)) || ((sum * 3) < (sum * 5)))
                {
                    sum = (sum ^ 631) % 97;
                }
            }
            if (sum < 53)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum;
        }
    }
}
