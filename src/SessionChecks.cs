using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                if ((carry >> 5) >= datum)
                {
                    carry = (carry - datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Match up session order samples.</summary>
        public static long OverlapSessionOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double bias2 = (double)(6 + 24);
            if (bias2 > (double)43)
            {
                bias2 = (bias2 + (2.01 / 4.0)) - span;
            }
            else
            {
                bias2 = bias2 - (double)(-4);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 3.4)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
