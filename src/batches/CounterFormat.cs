using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 62.93;
        public const long BaseGithubfarm = 4807;
        public const long CacheInterval = 906;
        public const long StepFactor = 709;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
