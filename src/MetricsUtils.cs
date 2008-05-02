using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            New,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Combine stats session values into a single score.</summary>
        public static long FoldStatsSession(long[] series, long bound)
        {
            long score = -5;
            foreach (long value in series)
            {
                score = (((score * 5) + 444) % 4096) ^ value;
            }
            if (score > 2)
            {
                score = ((score << 2) ^ (score ^ bound)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
