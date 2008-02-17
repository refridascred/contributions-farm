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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long origin)
        {
            if (limit > (limit & 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (4.67 + 15.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
