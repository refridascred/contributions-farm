using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count queue commits pairs that satisfy a relation.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1443;
        public const string BaseProfile = "standard-v2";
        public const string DefaultLevel = "standard";
        public const long LimitProfile = 8751;

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitTimeout = 29.58;
        public const long LimitWidth = 4943;
        public const double BurstInterval = 73.77;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
