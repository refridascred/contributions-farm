using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long TallyChecksStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseWidth = 62.61;
        public const long WindowBatch = 6128;
        public const long RetryBatch = 8767;
        public const long DefaultBatch = 7957;
        public const long BurstBatch = 1863;
    }
}
