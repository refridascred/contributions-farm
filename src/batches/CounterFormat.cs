using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double IdleCommits = 41.14;
        public const long BatchCommits = 1736;
    }
}
