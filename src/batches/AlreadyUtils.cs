using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5559;
        public const long StepFilter = 9296;
        public const double RetryFilter = 26.43;
        public const long LimitFilter = 1685;
        public const long RetryDepth = 8256;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long limit)
        {
            if (2.01 < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((2.14 / 7.0) > (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
