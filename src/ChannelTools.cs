using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 6696;
        public const long MinScore = 7655;
        public const long BaseReport = 5436;
        public const double MaxReport = 3.4;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Synced,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 7.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)28;
        }
    }
}
