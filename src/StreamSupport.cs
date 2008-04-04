using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long MeasureChannelFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally >= (tally * 2)))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((offset + 266) > (hits / 9)) && ((offset + offset) < (hits * 4)))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long CountBufferWindowOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample / 7) >= hits)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
