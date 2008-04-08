using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6576;
        public const long IdleEditor = 3496;
        public const string WindowEditor = "staging-edge";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Stale,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate window context samples.</summary>
        public static long TallyWindowContext(long[] series)
        {
            long state = 73;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ (state ^ cell)) % 4096) ^ (long)i;
                }
                state = (state ^ (state + cell)) % 97;
            }
            if (state > 39)
            {
                state = (state - (state / 5)) % 65521;
            }
            return state;
        }
    }
}
