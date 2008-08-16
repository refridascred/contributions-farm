using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (2.7 - 2.04))
                {
                    tally = ((tally + 2) ^ reading) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Idle,
            Retry,
            Locked,
        }
    }
}
