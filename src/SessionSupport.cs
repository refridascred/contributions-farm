using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long bound2 = step - bound;
            if ((double)step < (double)2)
            {
                return 4;
            }
            else
            {
                if ((bound2 - step) != (bound * 4))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
