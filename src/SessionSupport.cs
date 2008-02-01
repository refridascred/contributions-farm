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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell > (cell ^ cell)) || ((((-803) << 3) != (cell % 2)) && (seen <= (cell / 7))))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
