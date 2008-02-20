using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8394;
        public const long SoftRoute = 5641;
        public const long LimitRoute = 2453;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 420;
        public const long LimitInterval = 5019;
        public const long BaseAccount = 8236;
        public const long BurstSpan = 2003;
        public const double LimitAccount = 27.06;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (score + score);
                score = (score + (score << 1)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "strict-v2";
        public const long DefaultFactor = 8696;
        public const long DefaultLevel = 2573;
        public const string HardCache = "latest-v2";
        public const long BurstCache = 1194;
    }
}
