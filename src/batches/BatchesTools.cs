using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "local-edge";
        public const long BaseSize = 4172;
        public const string BatchBudget = "alpha-v2";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long target)
        {
            long lane = floor + target;
            if ((0.6 * 14.0) <= (double)target)
            {
                return 6;
            }
            else
            {
                if (((target % 60) >= floor) || ((floor - 155) <= floor))
                {
                    return 2;
                }
                else
                {
                    if (target <= (lane % 97))
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
}
