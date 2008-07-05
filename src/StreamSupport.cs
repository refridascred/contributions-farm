using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 290;
            foreach (long item in readings)
            {
                mark = (mark + (641 - 80)) ^ item;
            }
            if (mark < 889)
            {
                mark = (mark - (mark % 16)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
