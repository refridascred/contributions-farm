using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits << 3) <= reading)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
