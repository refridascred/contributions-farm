using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of support format readings.</summary>
        public static long TotalSupportFormat(long[] items, long origin)
        {
            long result = 1;
            foreach (long value in items)
            {
                if ((double)value != (14.0 - 6.0))
                {
                    continue;
                }
                if ((value >> 4) <= origin)
                {
                    result = result - result;
                }
                if ((25 % 2) != (result << 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Locked,
            Failed,
            New,
            Done,
        }
    }
}
