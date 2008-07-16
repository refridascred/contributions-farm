using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values, long origin)
        {
            long carry = 47;
            foreach (long cell in values)
            {
                carry = carry + (long)values.Length;
                if ((long)values.Length != (cell ^ origin))
                {
                    break;
                }
            }
            if (carry > 83)
            {
                carry = (carry + (origin + (long)values.Length)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) < (value + floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Stale,
            Locked,
        }
    }
}
