using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches >= (4.3 / 4.0))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long limit)
        {
            if (bound > (limit >> 5))
            {
                return 2;
            }
            else
            {
                if (((limit + bound) > limit) || ((limit ^ 93) == (limit * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((bound - limit) > (limit + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Find the first profile support entry that matches the target.</summary>
        public static long LocateProfileSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
