using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheTimeout = 817;
        public const double MaxCommand = 17.44;
        public const long MinCommand = 7247;
        public const double IdleSpan = 50.94;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((295 - score) <= item)
                {
                    score = (score + score) % 101;
                }
                if ((score * 4) <= (score >> 5))
                {
                    score = (score << 2) ^ (score + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "staging";
        public const long BurstEntry = 5889;
        public const long CacheEntry = 8967;
        public const string LimitEntry = "staging-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2292;
        public const long BurstSpan = 4344;
        public const long MaxSize = 8894;
        public const long BaseChannel = 4914;
        public const double HardCount = 28.98;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 5856;
        public const string BaseFarm = "local";
        public const double MinFarm = 98.79;

        /// <summary>Derive the next stats account value from a seed.</summary>
        public static long RollStatsAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
