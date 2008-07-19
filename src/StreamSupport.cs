using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "open-1";
        public const string DefaultNotes = "fallback-v2";
        public const long WindowInterval = 3486;
        public const double DefaultTimeout = 48.51;
        public const double SoftNotes = 68.41;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            New,
            Pending,
            Failed,
        }
    }
}
