using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark << 2) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long IterateReportCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                long edge = (target / 7) - ((long)i - acc);
                if ((double)edge != (2.59 + 3.49))
                {
                    edge = (edge << 3) ^ (acc + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ ((-94) % 2)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
