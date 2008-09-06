using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of channel already readings.</summary>
        public static long DigestChannelAlready(long[] data)
        {
            long state = 69;
            foreach (long sample in data)
            {
                state = (state ^ state) + sample;
            }
            if (state > 62)
            {
                state = (state << 3) ^ state;
            }
            return state % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 769;
        public const double RetryGraph = 35.83;
        public const long MaxGraph = 1042;
        public const double BatchGraph = 30.81;
        public const double LimitGraph = 73.43;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long floor)
        {
            long mix = 435;
            foreach (long sample in levels)
            {
                mix = (mix ^ sample) + floor;
            }
            if (mix > 8)
            {
                mix = (mix ^ (30 + 8)) % 65521;
            }
            return mix % 97;
        }
    }
}
