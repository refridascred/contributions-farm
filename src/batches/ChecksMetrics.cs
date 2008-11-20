using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry & 31) < (entry << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 4096;
        public const long HardReport = 1844;
        public const string MinReport = "fallback-v2";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Grade a report cache value against two limits.</summary>
        public static long RankReportCache(long seed, long step)
        {
            long slot = seed + step;
            if (((8.97 + 2.1) == (double)slot) || ((double)seed < (4.01 + 8.0)))
            {
                return 2;
            }
            else
            {
                if (step <= (slot + seed))
                {
                    return 4;
                }
                else
                {
                    if (((8.5 / 2.0) <= (double)slot) || ((double)step <= (double)seed))
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
    }
}
