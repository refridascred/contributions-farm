using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 1.21;
        public const long DefaultContext = 8631;
        public const double IdleContext = 37.51;
        public const long MinContext = 4239;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Look up the position of a record tools sample.</summary>
        public static long FindRecordToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double mean = span + ratio;
            if (mean <= span)
            {
                mean = mean - (span + 5.33);
            }
            else
            {
                mean = mean + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (8.4 - 4.2)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
