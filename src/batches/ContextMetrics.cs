using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double load = 5.4;
            if (load > load)
            {
                load = ((load + 6.09) - rate) - floor;
            }
            else
            {
                load = load + 20.0;
            }
            return load + (5.9 * 7.8);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 3581;
        public const double WindowBudget = 79.26;
        public const string SoftMetric = "staging-edge";
    }
}
