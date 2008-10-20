using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long target)
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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
