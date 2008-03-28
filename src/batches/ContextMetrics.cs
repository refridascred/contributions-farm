using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 3300;
        public const double DefaultContributi = 16.71;
        public const double LimitContributi = 46.71;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double bias = (gain / 8.0) * 0.4;
            if (bias <= (double)951)
            {
                bias = (bias - gain) - span;
            }
            return bias + (gain + 11.0);
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double BlendClusterStream(double ratio, double span)
        {
            double drift = span;
            return (drift - span) + ratio;
        }
    }
}
