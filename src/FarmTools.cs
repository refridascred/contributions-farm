using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)floor <= (1.9 + 6.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Look up the position of a support token sample.</summary>
        public static long LookupSupportTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
