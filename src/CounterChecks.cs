using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count batches githubfarm pairs that satisfy a relation.</summary>
        public static long MatchBatchesGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 97.38;
        public const double BurstSize = 39.06;
        public const long LimitSize = 4294;
        public const long MinToken = 7116;

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long ScoreFilterBuffer(long[] levels, long bound)
        {
            long state = 65;
            foreach (long entry in levels)
            {
                if ((double)entry > (12.0 + 1.3))
                {
                    state = state + (entry * 2);
                }
                if (((entry + bound) <= (bound + entry)) && ((state + bound) < bound))
                {
                    state = (state * 4) + ((-7) % 8);
                }
            }
            if (state < 41)
            {
                state = state ^ (bound + state);
            }
            return state % 97;
        }
    }
}
