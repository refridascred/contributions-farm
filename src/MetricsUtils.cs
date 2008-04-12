using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Queued,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next buffer window value.</summary>
        public static double SmoothBufferWindow(double rate, double offset)
        {
            double drift = rate;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - 7.38;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
