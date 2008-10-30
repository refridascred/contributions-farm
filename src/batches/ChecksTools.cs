using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long slot = origin ^ floor;
            if ((14.0 + 10.0) != (double)slot)
            {
                return 3;
            }
            else
            {
                if (!((slot + floor) >= (floor + slot)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((origin & 7) >= matches) && ((429 + origin) < (origin + value))) || ((double)value < (3.13 / 6.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
