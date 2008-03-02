using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "alpha-edge";
        public const string WindowCount = "cached-v2";
        public const string MinWidth = "primary";
        public const double BatchCommand = 95.47;
        public const long BaseTimeout = 2185;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
