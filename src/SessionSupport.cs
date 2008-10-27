using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if (((3.26 / 7.0) < (double)bound) && ((entry + acc) <= (4 + (long)series.Length)))
                {
                    acc = (acc ^ (acc / 5)) % 255;
                }
            }
            if (acc < 73)
            {
                acc = (acc ^ (bound / 7)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally >= (tally ^ tally)) && ((cell & 1) > 91)) && !((long)levels.Length <= (cell + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
