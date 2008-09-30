using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Failed,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long bound)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                if ((bound << 1) > bound)
                {
                    acc = (acc ^ (bound & 7)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (item / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((double)reading <= (4.05 + 5.1)) && ((reading / 6) <= (bound + hits))) || (bound < (reading / 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
