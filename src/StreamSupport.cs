using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long TotalContributiCommits(long[] levels, long floor)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((floor << 1) >= (sum * 5))
                {
                    sum = (sum + (floor << 2)) - reading;
                }
            }
            return sum % 65521;
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
