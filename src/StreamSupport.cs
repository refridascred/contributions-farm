using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long CombineBufferRecord(long[] samples)
        {
            long total = 98;
            foreach (long item in samples)
            {
                total = total ^ (item % 8);
            }
            return total;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
