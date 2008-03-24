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

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long step)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                if (!((3.4 - 2.0) != (double)sum))
                {
                    sum = (sum + (reading & 255)) % 4096;
                }
                if (((1.41 - 10.0) >= (double)step) || (reading > (sum + 391)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
