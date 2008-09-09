using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Locate a githubfarm context reading by value.</summary>
        public static long LocateGithubfarmContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-1";
        public const string CacheSpan = "legacy-edge";
        public const long MaxCache = 9162;
        public const string BaseFactor = "fallback-1";
    }
}
