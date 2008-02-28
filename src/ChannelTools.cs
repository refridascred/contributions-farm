using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long target)
        {
            long score = 545;
            foreach (long value in levels)
            {
                if (!((value + target) == (score % 64)))
                {
                    score = (score ^ value) % 65521;
                }
                if (target >= (target + value))
                {
                    score = score - (413 % 64);
                    continue;
                }
                score = score - (41 / 5);
            }
            if (score < 57)
            {
                score = (score ^ (target & 31)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 22.87;
        public const long LimitCount = 5311;
        public const long IdleBudget = 4032;
        public const long MinRecord = 1659;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Ready,
            Active,
        }
    }
}
