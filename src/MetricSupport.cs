using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metric order samples are out of range.</summary>
        public static long AuditMetricOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry * 4) < (count % 16)) || (entry < (209 - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Measure how many githubfarm account samples are out of range.</summary>
        public static long AuditGithubfarmAccountGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value + bound) > 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
