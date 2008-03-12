using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

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

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultTimeout = "staging-edge";
        public const long IdleSupport = 7887;
        public const long MinSupport = 8787;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((6.0 * 5.4) >= (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
