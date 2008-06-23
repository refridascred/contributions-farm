using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry <= (entry & 3)) || ((double)entry > (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine layout githubfarm values into a single score.</summary>
        public static long TotalLayoutGithubfarm(long[] data, long seed)
        {
            long carry = 478;
            foreach (long reading in data)
            {
                carry = ((carry + (2 % 3)) % 65521) ^ reading;
            }
            if (carry < (-8))
            {
                carry = (carry + (seed ^ 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
