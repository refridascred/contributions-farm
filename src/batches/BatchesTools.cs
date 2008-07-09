using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Active,
            Done,
            Ready,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long bound)
        {
            long offset = target ^ bound;
            if ((double)offset == (2.35 - 3.3))
            {
                return 7;
            }
            else
            {
                if ((498 - bound) > bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound >> 2) >= (offset + target)) && (target > (10 ^ offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
