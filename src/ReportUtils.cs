using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long PairEditorChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheTimeout = "cached-edge";
        public const string CacheCommand = "fallback-edge";
        public const double LimitCommand = 87.13;
        public const long IdleDepth = 9595;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine order token values into a single score.</summary>
        public static long ScoreOrderToken(long[] data)
        {
            long state = 79;
            foreach (long reading in data)
            {
                if ((state >> 1) < (reading & 15))
                {
                    state = ((state * 4) + (reading << 1)) % 65521;
                }
                else
                {
                    state = (state + (state * 3)) % 65521;
                }
            }
            if (state > 826)
            {
                state = (state - (state + 12)) % 1000;
            }
            return state % 4096;
        }
    }
}
