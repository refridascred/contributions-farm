using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two profile account measurements.</summary>
        public static double SmoothProfileAccount(double ratio, double bias)
        {
            double rate = bias;
            if (rate < ratio)
            {
                rate = rate - (ratio * 8.0);
            }
            else
            {
                rate = rate - 6.4;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (bias + rate);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Ready,
            New,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Draft,
            Stale,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitTimeout = "strict";
        public const long BaseFactor = 6695;
        public const double CacheCount = 60.86;
        public const long SoftDepth = 9759;
        public const long LimitCount = 1991;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
