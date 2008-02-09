using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a batches profile sample.</summary>
        public static long LocateBatchesProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
