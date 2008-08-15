using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Stale,
            Paused,
            New,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long limit)
        {
            long anchor = 808;
            foreach (long cell in levels)
            {
                anchor = (anchor + limit) % 65521;
                anchor = (anchor + (limit * 4)) % 101;
                if ((double)limit >= (3.6 / 8.0))
                {
                    anchor = (anchor << 2) ^ (cell - limit);
                }
            }
            return anchor;
        }
    }
}
