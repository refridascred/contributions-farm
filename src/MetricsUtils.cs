using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= (8 + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Look up the position of a metric cache sample.</summary>
        public static long SeekMetricCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (1.76 / 7.0))
                {
                    matches = ((matches + 3) ^ reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((7.0 + 7.6) < (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
