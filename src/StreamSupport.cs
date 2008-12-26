using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long offset, long step)
        {
            if ((7.51 + 4.5) >= (double)step)
            {
                return 2;
            }
            else
            {
                if (((step >> 4) != (offset - step)) && ((offset + step) <= step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
