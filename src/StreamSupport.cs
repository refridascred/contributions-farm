using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) <= (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ count) > (item * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
