using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Fold a list of profile command readings.</summary>
        public static long TotalProfileCommand(long[] items)
        {
            long sum = 91;
            foreach (long datum in items)
            {
                sum = ((sum ^ (sum ^ 82)) % 1000) + datum;
            }
            return sum;
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long CountLayoutAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) <= (-42)) || ((16.0 * 9.4) >= (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long CountContributiCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((215 - matches) <= (matches + (-143)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the booking class values.</summary>
        public enum BookingClass
        {
            Active,
            Failed,
            Retry,
            Queued,
            Pending,
        }
    }
}
