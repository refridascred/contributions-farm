using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter payload values into a single score.</summary>
        public static long WeighFilterPayload(long[] items, long target)
        {
            long state = 936;
            foreach (long value in items)
            {
                state = (state ^ (target >> 1)) + value;
            }
            if (state > 895)
            {
                state = ((state * 2) + state) % 97;
            }
            return state % 4096;
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
