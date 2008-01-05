using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = ((result - ((long)items.Length + seed)) % 101) - value;
            }
            return result % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Active,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((bound + bound) > (7 - bound))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
