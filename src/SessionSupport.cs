using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Queued,
            New,
            Retry,
            Pending,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + tally) == (3 + tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double bias, double floor)
        {
            double bias2 = (bias - bias) + (bias * 3.27);
            return (bias2 + (bias2 * 4.29)) + floor;
        }
    }
}
