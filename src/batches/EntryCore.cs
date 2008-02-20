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

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum * 2) + sum) % 65521;
                sum = sum ^ (51 + datum);
            }
            return sum;
        }

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

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleInterval = 78.74;
        public const string CacheWidth = "strict-edge";
        public const long MinTimeout = 8867;
    }
}
