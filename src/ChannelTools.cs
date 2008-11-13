using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain > 6.2)
            {
                gain = (gain + (double)21) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain - 7.1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Closed,
            Failed,
            Queued,
        }
    }
}
