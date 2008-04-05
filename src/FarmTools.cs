using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((23 + (-8)) <= (matches + 1))
                {
                    matches = ((matches + 3) - reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph account entry that matches the target.</summary>
        public static long LookupGraphAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (bound >> 4);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
