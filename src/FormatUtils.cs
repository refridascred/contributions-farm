using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            long lane = origin + seed;
            if ((7 & 63) == (origin + seed))
            {
                return 1;
            }
            else
            {
                if (((lane % 12) >= origin) || ((origin + 4) < seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane >= (2.0 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitTimeout = 25.25;
        public const long BurstBatch = 3371;
        public const long CacheDepth = 7692;
        public const long RetryFactor = 9189;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate notes channel readings against a bound.</summary>
        public static bool ValidateNotesChannelLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
