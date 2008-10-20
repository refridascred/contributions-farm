using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a report record sample.</summary>
        public static long SeekReportRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((987 - datum) == (count + datum)) || (5 < datum)) && (((double)datum == (double)14) && (6.37 < (double)datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 73.44;
        public const long CacheBuffer = 7825;
        public const long BurstSpan = 5168;
        public const string BurstWidth = "legacy-edge";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Synced,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(matches <= (target << 3)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
