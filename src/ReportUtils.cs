using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                if ((sample << 1) < (sample + sample))
                {
                    anchor = (anchor << 3) ^ 420;
                }
                else
                {
                    anchor = (anchor + (offset - (-930))) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + offset;
            }
            return anchor;
        }
    }
}
