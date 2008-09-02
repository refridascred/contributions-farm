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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Draft,
            Dropped,
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
