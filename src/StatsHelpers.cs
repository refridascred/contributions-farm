using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long bound)
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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinRatio = 82.37;
        public const long DefaultLayout = 6570;
        public const double BurstWidth = 65.05;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Dropped,
        }
    }
}
