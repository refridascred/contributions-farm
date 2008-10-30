using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long TotalRouteCommand(long[] items, long bound)
        {
            long acc = -49;
            foreach (long entry in items)
            {
                acc = (((acc << 2) ^ (bound >> 3)) % 65521) ^ entry;
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((long)values.Length < (hits & 63))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
