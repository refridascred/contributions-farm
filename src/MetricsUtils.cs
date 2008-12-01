using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Idle,
            Stale,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7890;
        public const string HardBuffer = "latest-edge";
        public const long BatchBuffer = 847;
        public const string MinBuffer = "stable-edge";
        public const long BurstBuffer = 4803;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double rate = (double)(-26) / 3.0;
            if (rate <= rate)
            {
                rate = rate + (rate - weight);
            }
            else
            {
                rate = rate - weight;
            }
            return rate - offset;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
