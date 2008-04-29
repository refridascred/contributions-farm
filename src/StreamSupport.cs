using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "standard-v2";
        public const string WindowGithubfarm = "strict-v2";
        public const string HardGithubfarm = "alpha-edge";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
