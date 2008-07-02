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

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            long delta = target - bound;
            if (target < (bound & 15))
            {
                return 7;
            }
            else
            {
                if ((target % 97) != (target & 127))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 3) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)bound < (double)25))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
