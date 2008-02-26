using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardTimeout = "stable-1";
        public const long MaxFactor = 9276;
        public const long RetryBuffer = 2275;
        public const string WindowRatio = "strict-edge";
        public const string MaxBuffer = "standard";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                if ((bound * 2) <= 805)
                {
                    score = ((score - (score & 31)) % 101) - cell;
                }
            }
            return score % 1000;
        }
    }
}
