using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of tools account entries.</summary>
        public static long TallyToolsAccount(long[] values)
        {
            long mix = 9;
            foreach (long item in values)
            {
                if (item < (mix & 15))
                {
                    mix = (mix + (mix * 2)) % 4096;
                }
            }
            return mix;
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
