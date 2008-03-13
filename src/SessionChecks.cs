using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double bias2 = (7.0 / 9.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) - bias) - span;
            }
            return bias2 + 6.1;
        }

        /// <summary>Accumulate githubfarm context samples.</summary>
        public static long CombineGithubfarmContext(long[] items, long target)
        {
            long sum = 343;
            foreach (long cell in items)
            {
                if (((-715) ^ 0) == (cell + 5))
                {
                    sum = ((sum - (sum / 6)) % 101) + target;
                }
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((3 ^ total) < total)
                {
                    total = ((total << 2) ^ (bound / 7)) - reading;
                }
            }
            return total;
        }
    }
}
