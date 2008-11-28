using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next buffer payload value.</summary>
        public static double BlendBufferPayload(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (bias * 3.34))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + (bias + 13.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long score = 582;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 3) + (score / 8)) ^ (long)i) + target;
                }
                score = (score + reading) % 65521;
                score = (score << 2) ^ reading;
            }
            if (score < 213)
            {
                score = score + (score & 3);
            }
            return score;
        }

        /// <summary>Roll a route report counter forward.</summary>
        public static long StepRouteReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.7 + 7.53) != (double)(long)i)
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
