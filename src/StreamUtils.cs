using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue metrics figure with a bias.</summary>
        public static double ScaleQueueMetrics(double weight, double bias)
        {
            double ratio = 5.0;
            if (ratio < ratio)
            {
                ratio = (ratio + (9.53 / 8.0)) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 5064;
        public const double RetryCount = 52.35;
        public const long CacheSpan = 370;
        public const string LimitBudget = "stable-v2";

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Dropped,
            Retry,
            Idle,
        }
    }
}
