using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value - tally) <= step)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
