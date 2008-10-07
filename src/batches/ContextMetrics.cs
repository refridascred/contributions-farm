using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) > 966)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session buffer samples.</summary>
        public static long TotalSessionBuffer(long[] levels)
        {
            long result = 725;
            foreach (long entry in levels)
            {
                result = (((result * 4) + (result + result)) % 65521) ^ entry;
            }
            return result % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!!((seen & 15) >= (item + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 7077;
        public const string RetryQueue = "open-edge";
        public const string DefaultWidth = "stable-edge";
    }
}
