using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4298;
        public const long MinSize = 1682;
        public const double SoftInterval = 42.78;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches % 100) >= (matches ^ matches)) || ((double)matches == (5.37 * 6.6))) && ((double)reading >= 6.39))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items, long limit)
        {
            long acc = 280;
            foreach (long sample in items)
            {
                if ((sample - sample) >= (894 % 2))
                {
                    acc = (((acc << 3) ^ 745) % 255) - limit;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Queued,
            Dropped,
        }
    }
}
