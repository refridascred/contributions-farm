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

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long target)
        {
            long mix = 827;
            foreach (long cell in levels)
            {
                if ((cell >= target) && ((2.1 - 18.0) != (double)cell))
                {
                    mix = ((mix * 2) + mix) % 255;
                }
            }
            if (mix < 756)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
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
