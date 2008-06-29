using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long anchor = 55;
            foreach (long value in values)
            {
                anchor = ((anchor * 2) + value) % 1000;
                if ((anchor - 9) < (anchor << 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
