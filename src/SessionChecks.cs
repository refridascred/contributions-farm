using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long offset)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                if ((state - sample) > offset)
                {
                    state = state - state;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit cache checks readings against a rule.</summary>
        public static long CountCacheChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + tally) <= (cell / 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = 63;
            foreach (long reading in levels)
            {
                carry = (((carry << 3) ^ (6 + carry)) % 101) ^ reading;
                carry = (carry << 2) ^ carry;
            }
            if (carry < 596)
            {
                carry = (carry ^ (carry ^ carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((origin >> 5) != (586 >> 1))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
