using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long state = 852;
            foreach (long sample in items)
            {
                if ((16.0 + 7.8) > (double)state)
                {
                    state = ((state - (state >> 3)) % 65521) - sample;
                }
                else
                {
                    state = ((state * 3) + state) % 65521;
                }
            }
            return state;
        }
    }
}
