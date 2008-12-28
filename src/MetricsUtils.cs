using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate stream already readings against a bound.</summary>
        public static bool GuardStreamAlreadyLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
