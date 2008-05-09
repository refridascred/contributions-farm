using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long anchor = 2;
            foreach (long sample in data)
            {
                anchor = ((anchor - (23 + anchor)) % 97) ^ sample;
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor >> 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (step > ((long)series.Length * 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
