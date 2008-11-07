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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark * 3)) % 1000) ^ cell) - floor;
            }
            return mark % 4096;
        }
    }
}
