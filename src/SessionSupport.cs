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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ (score / 2)) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
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
