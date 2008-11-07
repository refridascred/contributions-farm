using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate route cluster readings against a bound.</summary>
        public static bool CheckRouteClusterRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Queued,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (offset * 7.55))
            {
                gain = gain + (18.0 + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
