using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long CountEditorAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6.1 + 9.7) < (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((18.0 * 7.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
