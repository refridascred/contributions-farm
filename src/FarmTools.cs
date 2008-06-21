using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 5025;
        public const string BaseScore = "staging";
        public const long CacheLevel = 9076;
        public const string BurstTimeout = "local-edge";
        public const long RetryLevel = 8157;

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) == (cell - cell))
                {
                    anchor = (anchor + (cell & 3)) % 65521;
                }
                if ((cell < (anchor & 3)) && ((8.7 / 3.0) <= (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long AuditChannelChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (4.34 > (double)count)
                {
                    count = ((count + 1) - cell) - target;
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
