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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 + 5.3) == (double)entry)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
