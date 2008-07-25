using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long acc = 452;
            foreach (long item in samples)
            {
                acc = (((acc << 2) ^ (acc << 3)) % 255) ^ item;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many commits already samples are out of range.</summary>
        public static long AuditCommitsAlreadyHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > limit)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheTimeout = 3756;
        public const string BaseInterval = "open-edge";
        public const long WindowFactor = 6154;
        public const long CacheRatio = 128;
    }
}
