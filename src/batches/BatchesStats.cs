using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry % 10)) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Draft,
            Synced,
            Retry,
            Pending,
        }
    }
}
