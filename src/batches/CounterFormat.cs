using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                long cur = acc;
                acc = ((acc * 2) + (cur >> 1)) % 65521;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Pending,
            Done,
            Active,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
