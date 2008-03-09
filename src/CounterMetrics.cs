using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchInterval = 17.66;
        public const long LimitScore = 9313;
        public const double BatchContributi = 7.02;

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long TallyCommitsSupportOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + 681) >= (offset ^ tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue batch samples.</summary>
        public static long TallyQueueBatch(long[] items)
        {
            long mix = 398;
            foreach (long datum in items)
            {
                mix = ((mix << 3) ^ (mix + mix)) - datum;
            }
            return mix;
        }
    }
}
