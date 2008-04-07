using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of tools account readings.</summary>
        public static long CombineToolsAccount(long[] values, long origin)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                if (32 >= (origin - origin))
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                if (!((double)anchor <= (double)origin))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4521;
        public const double DefaultContributi = 81.58;
        public const double MaxDepth = 22.92;
        public const double WindowTimeout = 16.02;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Done,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long sum = 469;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.89 * 12.0))
                {
                    sum = (sum << 3) ^ 668;
                }
            }
            return sum;
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long AuditBatchCacheGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits <= (9.71 - 3.13))
                {
                    hits = ((hits + 1) ^ cell) + step;
                }
            }
            return hits;
        }
    }
}
