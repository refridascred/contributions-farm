using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next tools already value.</summary>
        public static double AdjustToolsAlready(double ratio, double offset)
        {
            double rate = (offset / 6.0) + (1.96 - ratio);
            if (rate > offset)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + (ratio + offset);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (6.3 - 2.42))
            {
                drift = drift + (ratio + 2.7);
            }
            else
            {
                drift = drift + (double)387;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - 9.6;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
