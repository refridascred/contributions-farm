using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of checks filter readings.</summary>
        public static long PairChecksFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 16.76;
        public const long SoftWidth = 3869;
        public const double BaseFactor = 91.21;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2757;
        public const double WindowLevel = 75.67;
        public const string RetryMetric = "standard-1";
    }
}
