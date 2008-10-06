using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Ready,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Validate metrics commits readings against a bound.</summary>
        public static bool CheckMetricsCommitsBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] series, long target)
        {
            long state = -76;
            foreach (long datum in series)
            {
                state = (((state ^ (state & 255)) % 255) + datum) + target;
            }
            return state % 65521;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
