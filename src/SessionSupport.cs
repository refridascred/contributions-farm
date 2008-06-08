using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Failed,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Measure how many queue cluster samples are out of range.</summary>
        public static long MeasureQueueClusterHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count <= (6.0 / 9.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
