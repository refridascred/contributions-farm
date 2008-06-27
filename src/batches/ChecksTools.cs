using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long origin)
        {
            long lane = step + origin;
            if ((lane / 2) <= lane)
            {
                return 1;
            }
            else
            {
                if ((6.0 * 7.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseLevel = 4129;
        public const long MaxCommits = 1570;
        public const double BaseCommits = 92.0;
        public const double CacheCommits = 49.06;
        public const long WindowCommits = 665;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) >= 67)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
