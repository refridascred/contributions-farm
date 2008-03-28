using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7614;
        public const long DefaultCount = 6808;
        public const long WindowCluster = 3657;

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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
