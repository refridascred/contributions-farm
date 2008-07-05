using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 290;
            foreach (long item in readings)
            {
                mark = (mark + (641 - 80)) ^ item;
            }
            if (mark < 889)
            {
                mark = (mark - (mark % 16)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (9.81 <= (double)hits)
                {
                    hits = ((hits + 2) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
