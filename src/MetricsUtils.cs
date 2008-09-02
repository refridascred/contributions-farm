using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally > (tally * 5))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = (acc * 5) + (datum + datum);
                if (datum >= (datum % 100))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitTimeout = 8812;
        public const double HardFarm = 87.62;
        public const double CacheFarm = 69.64;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Synced,
            Retry,
            Draft,
        }
    }
}
