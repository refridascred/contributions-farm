using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count metric stats pairs that satisfy a relation.</summary>
        public static long PairMetricStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Count the session report entries that pass the check.</summary>
        public static long MeasureSessionReportHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit - 64) == (limit * 3))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
