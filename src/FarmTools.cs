using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }
    }
}
