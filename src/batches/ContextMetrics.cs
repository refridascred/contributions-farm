using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 80.63;
        public const long RetrySize = 375;
        public const double MinBuffer = 18.93;
        public const double BaseBuffer = 26.82;
        public const long StepTimeout = 9810;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (matches + (long)levels.Length))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + matches) >= 858))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
