using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a metrics channel reading by value.</summary>
        public static long LookupMetricsChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 4) != (sample * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 4930;
        public const long MinDepth = 1930;
        public const string IdleGithubfarm = "cached-v2";
    }
}
