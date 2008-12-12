using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            if (5.7 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed >= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
