using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5453;
        public const long MinProfile = 16;
        public const string RetrySize = "strict-1";

        /// <summary>Roll a stats context counter forward.</summary>
        public static long SeriesStatsContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Dropped,
            Idle,
            Active,
        }
    }
}
