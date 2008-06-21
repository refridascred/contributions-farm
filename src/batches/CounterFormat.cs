using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long limit)
        {
            long span = origin ^ limit;
            if (((302 * 3) <= (origin << 3)) && ((origin & 127) > (origin + limit)))
            {
                return 5;
            }
            else
            {
                if ((span << 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((163 & 1) == (limit >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long state = 261;
            foreach (long datum in items)
            {
                state = (state ^ (datum & 127)) + origin;
            }
            return state % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
