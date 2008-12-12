using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Pending,
            New,
            Done,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long mark = 143;
            foreach (long cell in samples)
            {
                if (!((mark - mark) >= cell))
                {
                    mark = (mark ^ mark) % 101;
                }
                if ((381 < mark) || (mark <= (780 - cell)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
