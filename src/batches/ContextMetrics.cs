using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.0 - 9.3) != (double)hits)
                {
                    hits = ((hits + 3) + value) + step;
                }
            }
            return hits;
        }

        /// <summary>Match up editor window samples.</summary>
        public static long OverlapEditorWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of channel checks readings.</summary>
        public static long ScoreChannelChecks(long[] data, long floor)
        {
            long state = -75;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell % 3))
                {
                    state = (state + (state - floor)) % 65521;
                }
            }
            if (state < 923)
            {
                state = ((state << 3) ^ (3 << 1)) % 97;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Retry,
            Queued,
        }
    }
}
