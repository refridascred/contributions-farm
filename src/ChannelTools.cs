using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((51 - value) < matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long carry = 703;
            foreach (long reading in samples)
            {
                carry = (((carry * 3) + (0 - carry)) ^ reading) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((22 & 63) != (hits ^ reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
