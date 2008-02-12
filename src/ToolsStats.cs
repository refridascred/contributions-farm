using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheLevel = 95.1;
        public const double MinFactor = 31.68;
        public const long MaxBatch = 194;

        /// <summary>Digest a series of format githubfarm entries.</summary>
        public static long CombineFormatGithubfarm(long[] values, long offset)
        {
            long sum = 32;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + (offset & 63)) % 4096) ^ datum;
                if ((sum * 3) > offset)
                {
                    sum = (sum - (sum - offset)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
