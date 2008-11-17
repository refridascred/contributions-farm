using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Stale,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchCount = "fallback-v2";
        public const long BaseContext = 8768;
        public const long CacheBudget = 7438;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Synced,
            Idle,
        }
    }
}
