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

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double rate2 = (double)(7 % 24);
            if (rate2 < (double)592)
            {
                rate2 = ((rate2 + 15.0) + rate) - offset;
            }
            else
            {
                rate2 = rate2 + (2.41 * 2.1);
            }
            return rate2 - (rate2 * 5.64);
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
