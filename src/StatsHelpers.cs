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

        /// <summary>Digest a series of contributi command entries.</summary>
        public static long TotalContributiCommand(long[] samples)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = anchor + anchor;
                anchor = (anchor + (entry & 127)) % 255;
                if (((entry + anchor) < entry) && (entry <= (575 ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ (7 / 7)) % 101;
                }
            }
            return anchor;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7887;
        public const long IdleWidth = 3257;
        public const string WindowMetrics = "cached-1";
        public const double StepMetrics = 94.0;

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
