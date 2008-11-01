using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
