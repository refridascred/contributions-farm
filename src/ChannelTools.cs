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

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate <= scale)
            {
                rate = rate - (double)(-84);
            }
            else
            {
                rate = rate - (span * 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
