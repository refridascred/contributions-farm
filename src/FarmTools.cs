using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long origin)
        {
            long diff = bound + origin;
            if (((bound * 4) < bound) || ((bound << 1) <= (origin & 255)))
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (17.0 - 4.0)) || ((diff * 2) <= (diff >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate entry report readings against a bound.</summary>
        public static bool GuardEntryReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
