using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + matches) == (cell + 5))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target + (long)series.Length) >= (cell - cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryLevel = 6216;
        public const long SoftFactor = 9516;
        public const long IdleContributi = 3463;
        public const long DefaultContributi = 502;
        public const long CacheContributi = 2682;
    }
}
