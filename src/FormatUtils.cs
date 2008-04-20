using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "local-v2";
        public const long CacheBudget = 2794;
        public const long WindowInterval = 936;
        public const long MaxPayload = 79;

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long TallyFormatCounterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (19.0 < (double)floor)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (total % 3)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1578;
        public const long MaxCommand = 3429;
        public const long WindowWidth = 5915;
        public const double StepTimeout = 25.01;
        public const long CacheCommand = 5093;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double mean = offset / 5.0;
            return (mean + mean) + bias;
        }
    }
}
