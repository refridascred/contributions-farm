using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((198 < (anchor % 64)) || (anchor > (8 & 15)))
                {
                    anchor = (((anchor - (42 ^ 492)) % 65521) + sample) + step;
                }
            }
            return anchor;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (floor < (floor + floor))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
