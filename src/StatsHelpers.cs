using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long seed)
        {
            if ((92 << 3) >= (limit - limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (4.89 * 0.8))
                {
                    return 4;
                }
                else
                {
                    if ((limit + seed) > (1 + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) == (limit / 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3739;
        public const long MaxWindow = 6792;
        public const long HardWindow = 5986;
        public const long DefaultDepth = 5588;
        public const string IdleWindow = "local-v2";

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
