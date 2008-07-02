using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long AuditFarmCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((-342) / 5) == (8 + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order route samples.</summary>
        public static long FoldOrderRoute(long[] series)
        {
            long acc = 39;
            foreach (long sample in series)
            {
                acc = (acc ^ sample) % 97;
            }
            if (acc > 52)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Failed,
            Active,
            Locked,
            Paused,
        }
    }
}
