using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Synced,
            Idle,
            Stale,
            New,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((bound - (long)levels.Length) > (801 + hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseFactor = 95.33;
        public const long LimitGithubfarm = 8649;
        public const double StepGithubfarm = 52.48;
        public const long BatchGithubfarm = 596;
    }
}
