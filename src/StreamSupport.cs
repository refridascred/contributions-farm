using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of command session readings.</summary>
        public static long CombineCommandSession(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                state = state + (state + state);
                if ((sample + sample) <= state)
                {
                    state = (state << 2) ^ (state << 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7719;
        public const long IdleLevel = 425;
        public const long MaxSupport = 9459;
        public const double WindowSupport = 23.18;
    }
}
