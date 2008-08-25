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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)hits <= (double)9) || ((limit << 1) < hits))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 4930;
        public const long MinDepth = 1930;
        public const string IdleGithubfarm = "cached-v2";
    }
}
