using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleBudget = 73.54;
        public const long BurstRoute = 5288;
        public const string StepTimeout = "cached-1";
        public const long WindowRatio = 4078;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (8 / 3)) % 101;
                result = ((result << 2) ^ (bound >> 4)) % 4096;
                result = ((result * 4) + result) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
