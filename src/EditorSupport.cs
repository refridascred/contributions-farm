using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((seed + seed) != (seed * 4)) && ((hits * 4) > (seed + hits))) || ((5 - 164) < (seed << 2)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = (anchor * 3) + 33;
                anchor = anchor - datum;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 3) + (anchor + 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a order queue reading.</summary>
        public static double AdjustOrderQueue(double ratio, double span)
        {
            double weight = (ratio / 6.0) + 6.15;
            if (weight < weight)
            {
                weight = weight + (span / 5.0);
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            return weight + ratio;
        }
    }
}
