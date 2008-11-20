using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings)
        {
            long anchor = 165;
            foreach (long reading in readings)
            {
                if (!((anchor ^ anchor) > (reading & 7)))
                {
                    anchor = anchor + (anchor - reading);
                }
            }
            if (anchor > 979)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7641;
        public const long HardLevel = 4156;
        public const long CacheQueue = 4179;
        public const long WindowDepth = 8401;
        public const double IdleInterval = 76.35;

        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long TallyGithubfarmChecksHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 9) <= (entry + count))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
