using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((4 & 7) != (value - floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long MeasureTokenCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 7) > (item * 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long CountStreamContextOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9 >> 1) > (count + entry))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
