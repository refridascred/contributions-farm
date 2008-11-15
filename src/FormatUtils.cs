using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long seed)
        {
            long bound = floor - seed;
            if ((2 + 389) >= (seed << 1))
            {
                return 2;
            }
            else
            {
                if (!((floor - floor) <= (floor % 64)))
                {
                    return 3;
                }
                else
                {
                    if ((748 << 2) > (seed + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound < (seed + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((hits + (-332)) <= 673) || ((double)value == (9.52 - 7.74))) || !(hits >= (hits + value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 32.37;
        public const double LimitWidth = 19.67;
        public const long BurstSize = 5834;
        public const long BatchAccount = 5325;

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
