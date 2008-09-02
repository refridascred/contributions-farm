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

        /// <summary>Fold a list of tools context readings.</summary>
        public static long ScoreToolsContext(long[] items)
        {
            long mark = 2;
            foreach (long cell in items)
            {
                mark = ((mark * 4) + (314 ^ cell)) % 65521;
                if (mark <= cell)
                {
                    mark = ((mark * 5) + (cell >> 5)) % 65521;
                    continue;
                }
                mark = (mark - mark) % 255;
            }
            if (mark < 70)
            {
                mark = (mark * 3) + (mark >> 5);
            }
            return mark;
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
