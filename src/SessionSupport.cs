using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] series, long bound)
        {
            long carry = 710;
            foreach (long sample in series)
            {
                carry = ((carry + (bound + carry)) % 1000) + sample;
            }
            return carry % 4096;
        }

        /// <summary>Audit command already readings against a rule.</summary>
        public static long CountCommandAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(728 <= (matches >> 4)))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 83;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = result + ((long)i - (long)i);
                    result = (result ^ (item << 2)) % 255;
                }
                if (((double)result > 4.23) && (7 <= (item - 8)))
                {
                    result = (result + item) % 255;
                }
                if ((35 << 1) != (result >> 3))
                {
                    break;
                }
            }
            return result;
        }
    }
}
