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

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Adjust a stats route reading.</summary>
        public static double ProjectStatsRoute(double rate, double span)
        {
            double scale = span - (double)3;
            if (scale <= span)
            {
                scale = scale + (rate * 6.4);
            }
            return scale + (rate * 13.0);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Grade a batches context value against two limits.</summary>
        public static long RankBatchesContext(long step, long target)
        {
            long offset = step + target;
            if (step < (63 * 3))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) <= (14 + step)))
                {
                    return 4;
                }
                else
                {
                    if ((7 ^ target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
