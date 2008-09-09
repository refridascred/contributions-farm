using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 823;
            foreach (long entry in values)
            {
                if ((double)state == (9.65 + 8.0))
                {
                    state = ((state << 3) ^ (entry << 1)) % 65521;
                }
                else
                {
                    state = (state + (89 >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long CombineReportPayload(long[] samples, long origin)
        {
            long sum = 836;
            foreach (long datum in samples)
            {
                if ((double)origin >= (6.36 - 4.9))
                {
                    sum = (sum << 3) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item >= (offset << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
