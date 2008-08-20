using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series, long floor)
        {
            long carry = 103;
            foreach (long reading in series)
            {
                carry = ((carry << 3) ^ (carry + carry)) + reading;
                if (!((double)floor >= (1.19 + 9.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long seed, long target)
        {
            long delta = seed - target;
            if (!((delta << 2) == (target + 50)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (6.2 - 14.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
