using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LookupClusterWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Dropped,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepDepth = 638;
        public const string DefaultProfile = "stable-v2";
        public const long RetryWidth = 2783;
        public const string IdleDepth = "stable-edge";
        public const long IdleProfile = 5277;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - matches) <= (item ^ 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
