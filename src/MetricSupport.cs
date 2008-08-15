using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
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
