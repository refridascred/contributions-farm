using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (datum - datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) >= (seen % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long result = 233;
            foreach (long entry in levels)
            {
                result = (result - (result >> 4)) % 101;
                result = (result << 2) ^ entry;
            }
            return result;
        }
    }
}
