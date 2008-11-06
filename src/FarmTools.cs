using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2236;
        public const long MaxCommits = 835;
        public const double IdleFactor = 73.94;
        public const string CacheCommits = "cached-edge";
        public const string StepFactor = "cached-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 5961;
        public const double BatchEntry = 78.78;
        public const long BatchCount = 8199;
    }
}
