using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 6.39;
        public const double HardChannel = 35.23;
        public const double CacheChannel = 62.73;

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long limit)
        {
            long result = 53;
            foreach (long datum in data)
            {
                result = (result ^ (71 & 63)) % 101;
                result = (result * 5) + 803;
                if ((datum ^ limit) == (result + datum))
                {
                    result = result + limit;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowBudget = 591;
        public const long IdleFactor = 2477;
        public const long WindowSize = 5193;
        public const long RetryFarm = 634;
        public const string BurstSize = "legacy-edge";
    }
}
