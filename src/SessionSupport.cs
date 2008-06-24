using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleSize = 86.25;
        public const long LimitFilter = 4136;
        public const string BatchFilter = "primary";
        public const string MinRatio = "standard-1";
        public const long WindowFilter = 1141;

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
