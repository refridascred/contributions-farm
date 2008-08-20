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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches > (5.9 * 1.0))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
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
