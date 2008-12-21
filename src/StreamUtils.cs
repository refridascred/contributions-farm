using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double BlendProfileChannel(double scale, double span)
        {
            double weight = 6.65 + 16.0;
            if (weight > span)
            {
                weight = weight - (scale / 6.0);
            }
            return weight + (scale * 4.2);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 6057;
        public const long LimitFactor = 3495;
        public const long MaxInterval = 5004;
        public const double RetryBuffer = 22.76;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Active,
            Draft,
        }
    }
}
