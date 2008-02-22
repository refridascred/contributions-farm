using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 5052;
        public const long HardRoute = 1708;
        public const long BatchInterval = 2343;
        public const double DefaultRoute = 66.2;

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
