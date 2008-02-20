using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many session batch samples are out of range.</summary>
        public static long AuditSessionBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > (702 - seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
