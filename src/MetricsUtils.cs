using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long mix = -399;
            foreach (long sample in series)
            {
                mix = (mix ^ (mix - sample)) + limit;
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ (mix >> 5)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 4767;
        public const long LimitInterval = 3295;
        public const string IdleSpan = "latest-v2";
        public const long WindowBudget = 6447;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Combine record farm values into a single score.</summary>
        public static long TallyRecordFarm(long[] items, long seed)
        {
            long anchor = 221;
            foreach (long cell in items)
            {
                if (((double)anchor >= (5.71 + 17.0)) && ((7.11 + 6.8) < (double)seed))
                {
                    anchor = (anchor + anchor) ^ cell;
                }
            }
            return anchor % 97;
        }
    }
}
