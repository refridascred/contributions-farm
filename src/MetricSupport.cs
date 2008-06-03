using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry / 9) <= 226) || ((double)seen == (19.0 / 2.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long BucketCacheGithubfarm(long bound, long offset)
        {
            long step = bound + offset;
            if ((offset + (-7)) >= (offset * 5))
            {
                return 1;
            }
            else
            {
                if ((776 >> 4) >= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
