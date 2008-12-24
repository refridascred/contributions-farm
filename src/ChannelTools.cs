using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 9776;
        public const string MaxRatio = "stable-edge";
        public const long BurstFarm = 3982;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double scale2 = scale + offset;
            if (scale2 <= scale2)
            {
                scale2 = scale2 + offset;
            }
            return scale2 + (offset - 2.2);
        }
    }
}
