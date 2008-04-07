using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits ^ 760) < (hits & 63))
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
