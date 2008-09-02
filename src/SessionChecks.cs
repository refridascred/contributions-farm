using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (0.7 / 5.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long TallyNotesProfile(long[] items)
        {
            long sum = 31;
            foreach (long entry in items)
            {
                sum = (((sum << 2) ^ 649) % 255) - entry;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long acc = 333;
            foreach (long value in levels)
            {
                acc = (acc - (value + acc)) % 97;
            }
            if (acc > 1)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }
    }
}
