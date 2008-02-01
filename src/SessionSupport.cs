using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command checks reading.</summary>
        public static double ProjectCommandChecks(double bias, double bias2)
        {
            double rate = (bias2 - 0.4) - (double)742;
            if (rate >= (rate * 6.5))
            {
                rate = (rate + (double)520) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (1.25 * 5.75);
        }

        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long origin, long step)
        {
            long slot = origin ^ step;
            if ((slot & 1) < step)
            {
                return 7;
            }
            else
            {
                if (step > (origin & 127))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
