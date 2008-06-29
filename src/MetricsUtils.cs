using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a stats cache reading.</summary>
        public static double BlendStatsCache(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)2)
            {
                ratio = ratio + (ratio + ratio);
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio - (gain - ratio);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 1480;
        public const long IdleAlready = 4569;
        public const long MinAlready = 3532;

        /// <summary>Scale a already profile figure with a bias.</summary>
        public static double BlendAlreadyProfile(double scale, double bias)
        {
            double rate = scale - (double)524;
            return rate + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long mix = 62;
            foreach (long entry in readings)
            {
                if (((-236) >> 1) <= (entry << 1))
                {
                    mix = mix - (346 << 3);
                }
                else
                {
                    mix = mix + (entry >> 4);
                }
            }
            return mix % 97;
        }
    }
}
