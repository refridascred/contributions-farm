using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1492;
        public const string BatchCommits = "primary-edge";
        public const long IdleCount = 140;
        public const long DefaultSpan = 3335;
        public const long CacheCount = 8763;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 46;
            foreach (long item in levels)
            {
                state = (state + ((long)levels.Length ^ state)) % 1000;
                if (state <= (item * 2))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
