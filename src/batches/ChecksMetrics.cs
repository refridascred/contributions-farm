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

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = -8;
            foreach (long item in levels)
            {
                if ((11.0 + 1.3) > (double)item)
                {
                    sum = sum ^ (item / 4);
                }
                else
                {
                    sum = sum ^ (sum - item);
                }
                if ((double)956 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
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
