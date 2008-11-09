using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset - 88) == ((long)i + offset))
                {
                    state = state + offset;
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCount = 78.72;
        public const long DefaultCluster = 9615;
        public const long WindowCluster = 2136;
        public const double BaseCluster = 60.68;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long ScoreAccountFarm(long[] values, long limit)
        {
            long result = 81;
            foreach (long value in values)
            {
                if ((double)result == (5.81 + 8.78))
                {
                    result = (((result << 2) ^ (value - result)) % 65521) - limit;
                }
            }
            return result % 1000;
        }
    }
}
