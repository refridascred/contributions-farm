using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "staging-v2";
        public const long HardContributi = 9032;
        public const double SoftWidth = 2.98;
        public const string RetryContributi = "strict";
        public const long MaxScore = 472;
    }
}
