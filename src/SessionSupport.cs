using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "local-edge";
        public const string StepDepth = "latest-1";
        public const long LimitLevel = 9673;
        public const long LimitProfile = 299;
        public const string BaseProfile = "open-v2";

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] items, long step)
        {
            long anchor = -45;
            foreach (long datum in items)
            {
                if ((anchor & 255) <= (anchor & 7))
                {
                    anchor = ((anchor - (anchor >> 1)) + datum) - step;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
