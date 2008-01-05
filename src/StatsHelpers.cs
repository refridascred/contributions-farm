using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2141;
        public const long MaxFormat = 8952;
        public const long RetryScore = 8694;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value - seen) <= (seen * 4)) && ((double)seen != (10.0 * 6.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 10.1;
        public const long BurstChannel = 1904;
        public const long SoftFactor = 3128;
        public const long IdleChannel = 9892;
        public const long HardInterval = 9264;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((3.67 / 5.0) != (double)(long)series.Length)
                {
                    seen = ((seen + 2) + cell) - origin;
                }
            }
            return seen;
        }
    }
}
