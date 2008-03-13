using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two batches checks measurements.</summary>
        public static double ScaleBatchesChecks(double scale, double floor)
        {
            double ratio = (double)(-470) / 8.0;
            return (ratio + (ratio + scale)) + floor;
        }
    }
}
