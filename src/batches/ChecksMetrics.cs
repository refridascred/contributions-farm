using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "fallback-1";
        public const string RetryDepth = "alpha";
        public const double CacheSchema = 98.11;
        public const long WindowSchema = 1812;
        public const long WindowDepth = 7226;

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

        /// <summary>Compare every pair of profile filter readings.</summary>
        public static long PairProfileFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Dropped,
            Active,
        }

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
