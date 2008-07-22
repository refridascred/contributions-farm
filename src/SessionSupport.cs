using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double rate = 7.9;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                if ((cell >> 1) <= ((long)items.Length ^ cell))
                {
                    result = ((result << 3) ^ (378 * 3)) % 255;
                }
                if (result > (cell >> 4))
                {
                    break;
                }
            }
            if (result > 877)
            {
                result = result ^ (origin / 9);
            }
            return result % 65521;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (((step * 2) > (step ^ bound)) && ((1.0 + 3.15) == (double)bound))
            {
                return 7;
            }
            else
            {
                if ((1.8 * 11.0) == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
