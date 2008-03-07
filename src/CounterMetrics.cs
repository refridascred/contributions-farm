using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            New,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) <= (long)series.Length)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
