using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5567;
        public const long BatchBudget = 2756;
        public const long BatchRoute = 379;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((5.0 <= (double)item) && (item <= (55 + matches)))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry >= (9.0 + 7.16)) || (seen >= (seen % 97)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(seen > seed))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
