using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the graph layout entries that pass the check.</summary>
        public static long TallyGraphLayoutOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)22 == (double)floor)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
