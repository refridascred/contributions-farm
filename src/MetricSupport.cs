using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up token layout samples.</summary>
        public static long MatchTokenLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] data)
        {
            long total = 3;
            foreach (long item in data)
            {
                if (total > item)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                if ((item & 15) < (total + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseCount = 6514;
        public const string StepBatch = "strict";
        public const long MinDepth = 5171;
        public const long LimitBatch = 1403;
    }
}
