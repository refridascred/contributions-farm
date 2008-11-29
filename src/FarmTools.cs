using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 7106;
        public const string DefaultEditor = "alpha-v2";
        public const string MaxEditor = "primary-v2";
        public const long StepTimeout = 9149;
        public const long IdleEditor = 9219;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinBudget = 9559;
        public const long StepCount = 7158;
        public const long WindowCount = 7696;
        public const long BatchCache = 5924;
        public const double MaxCache = 10.29;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
