using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 64) == (tally >> 1))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long CountPayloadEntryGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count >= (5 + entry)) || ((37 % 8) <= (count - count))) || (((91 ^ count) > (entry / 4)) || ((double)(-9) < (double)count)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
