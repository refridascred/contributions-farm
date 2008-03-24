using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long SortCommitsFilter(long step, long target)
        {
            if (((540 + target) >= (target + target)) || ((double)target <= (double)step))
            {
                return 0;
            }
            else
            {
                if (6 < (step - target))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (target % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstWidth = 84.98;
        public const double MinCommand = 49.11;
        public const long BaseCommand = 2075;
        public const long RetryBudget = 8994;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
