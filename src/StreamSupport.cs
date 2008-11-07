using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long origin)
        {
            long state = 40;
            foreach (long entry in samples)
            {
                if ((origin >> 3) <= state)
                {
                    state = (((state * 2) + 77) % 65521) + entry;
                    continue;
                }
                state = (state - 8) % 65521;
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) < (count % 10))
                {
                    count = count + 1;
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
