using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9991;
        public const long MaxWidth = 4714;
        public const string BurstWidth = "fallback-edge";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((count >> 3) >= reading) && ((step - 265) <= (10 & 15))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
