using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((seed / 9) >= reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already profile samples.</summary>
        public static long ScoreAlreadyProfile(long[] items, long seed)
        {
            long carry = -580;
            foreach (long item in items)
            {
                carry = (((carry - (carry * 3)) % 65521) - item) - seed;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((69 >> 4) > (tally & 1))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
