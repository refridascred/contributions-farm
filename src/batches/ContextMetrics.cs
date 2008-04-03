using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long seed)
        {
            long anchor = -78;
            foreach (long entry in samples)
            {
                if ((seed >> 4) <= seed)
                {
                    anchor = ((anchor * 3) + (3 >> 4)) ^ entry;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 8) % 1000;
                }
            }
            if (anchor < 631)
            {
                anchor = ((anchor * 4) + 9) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate metric buffer samples.</summary>
        public static long TallyMetricBuffer(long[] items, long limit)
        {
            long sum = 45;
            foreach (long sample in items)
            {
                if ((sum % 24) < limit)
                {
                    sum = (sum - (119 ^ sum)) - sample;
                }
            }
            if (sum < 430)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((limit % 16) >= (value / 7)) || !(3 < limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
