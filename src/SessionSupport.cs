using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items, long limit)
        {
            long score = 4;
            foreach (long entry in items)
            {
                score = ((score ^ (score + 4)) ^ entry) - limit;
            }
            return score;
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
