using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4083;
        public const long DefaultAccount = 9489;
        public const string BaseAccount = "latest-v2";
        public const string DefaultTimeout = "primary-edge";
        public const string WindowAccount = "fallback-1";

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((limit * 4) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if (!((step << 1) < (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) <= (seed + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches != (2.38 * 6.0))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 9) < (count % 97))
                {
                    count = ((count + 1) + reading) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
