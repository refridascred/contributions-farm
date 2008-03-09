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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >> 2) < (bound ^ entry))
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
