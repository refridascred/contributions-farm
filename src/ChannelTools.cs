using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSpan = 9802;
        public const long CacheFactor = 8260;
        public const double LimitOrder = 30.88;
        public const double IdleOrder = 59.78;
        public const string BatchOrder = "standard-v2";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
