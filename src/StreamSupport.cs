using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = -1;
            foreach (long reading in items)
            {
                if (state <= (reading + 288))
                {
                    state = ((state * 3) + (state >> 3)) % 97;
                }
                else
                {
                    state = state ^ (reading % 97);
                }
                if (391 > reading)
                {
                    state = ((state * 2) + (reading + state)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long DefaultSession = 4043;
        public const long LimitSession = 2241;
        public const long MaxSession = 2933;
    }
}
