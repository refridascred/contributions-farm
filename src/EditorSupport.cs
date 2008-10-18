using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Queued,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Scale a batches command figure with a bias.</summary>
        public static double ScaleBatchesCommand(double bias, double span)
        {
            double ratio = span;
            if (ratio <= 11.0)
            {
                ratio = (ratio - span) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 7.91);
            }
            return ratio - span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 8) > (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
