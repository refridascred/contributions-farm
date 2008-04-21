using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                if ((57 - datum) < 9)
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((datum > (acc + datum)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit - limit) != (datum / 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
