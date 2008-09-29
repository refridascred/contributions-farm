using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Dropped,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSize = 2005;
        public const double BurstSpan = 69.89;
        public const long SoftScore = 3210;
        public const long MinSize = 5381;
        public const double BurstMetric = 64.41;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 9762;
        public const long DefaultScore = 4370;
        public const double SoftCommits = 7.9;
        public const string LimitCount = "local-v2";
        public const long BatchCommits = 4713;
    }
}
