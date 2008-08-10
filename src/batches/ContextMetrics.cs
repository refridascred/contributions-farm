using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double drift = bias / 9.0;
            if (drift > (double)2)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)247;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7507;
        public const double BatchTimeout = 45.59;
        public const double StepCounter = 34.95;
        public const string MaxCounter = "open";
    }
}
