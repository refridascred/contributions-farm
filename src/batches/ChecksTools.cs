using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long carry = 11;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + (entry / 7)) % 101;
                if ((3 * 4) > (step - entry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next already order value.</summary>
        public static double BlendAlreadyOrder(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > (bias * 9.04))
            {
                ratio2 = (ratio2 - (double)41) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (bias / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - bias) - (double)(long)i;
            }
            return ratio2 - (double)16;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 8;
            foreach (long value in samples)
            {
                total = ((((total * 3) + (500 ^ total)) % 4096) + value) + seed;
            }
            return total;
        }
    }
}
