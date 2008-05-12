using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "staging-1";
        public const long RetryRatio = 8442;
        public const long BaseStats = 9765;
        public const long SoftStats = 539;
        public const long WindowStats = 7582;

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long BaseSize = 8139;
        public const double IdleToken = 49.19;
        public const long StepCount = 1641;
    }
}
