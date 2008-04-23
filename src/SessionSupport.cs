using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long seed)
        {
            long carry = 18;
            foreach (long cell in series)
            {
                carry = ((carry + (cell + 179)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Fold a list of route graph readings.</summary>
        public static long TotalRouteGraph(long[] readings, long offset)
        {
            long sum = -8;
            foreach (long item in readings)
            {
                if (item >= (offset - item))
                {
                    sum = (sum ^ ((long)readings.Length * 4)) % 4096;
                }
            }
            if (sum < 42)
            {
                sum = (sum << 2) ^ (offset % 7);
            }
            return sum % 65521;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Pending,
            Done,
            Stale,
        }
    }
}
