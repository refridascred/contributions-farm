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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Locked,
            Stale,
            Paused,
            Idle,
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
