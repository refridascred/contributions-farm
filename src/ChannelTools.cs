using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = -197;
            foreach (long sample in values)
            {
                if ((state + sample) < (sample - state))
                {
                    state = (state * 3) + (sample + state);
                }
                if (2 > (state >> 1))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 9);
            }
            return state;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1286;
        public const string IdleRatio = "local-v2";
        public const double HardDepth = 51.49;
        public const string CacheDepth = "stable-edge";
        public const string WindowLevel = "standard-v2";
    }
}
