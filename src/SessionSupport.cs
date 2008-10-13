using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long limit)
        {
            long result = 73;
            foreach (long value in values)
            {
                if ((double)result >= (4.0 + 2.0))
                {
                    result = result + (limit % 16);
                }
                else
                {
                    result = (result * 2) + (value - limit);
                }
            }
            if (result < 41)
            {
                result = result - limit;
            }
            return result % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (limit < (82 % 64))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "local-edge";
        public const long SoftTools = 3266;
        public const long LimitScore = 1932;
        public const string BurstTimeout = "fallback-1";
        public const string MinTools = "staging-1";
    }
}
