using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 84;
            foreach (long datum in levels)
            {
                if ((datum - result) >= (result ^ result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result > 4)
            {
                result = (result ^ (result * 5)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long ScoreFilterWindow(long[] values, long floor)
        {
            long state = 19;
            foreach (long sample in values)
            {
                if (sample < (floor % 97))
                {
                    state = (state - (floor << 2)) % 65521;
                }
                if ((floor >> 4) <= (state ^ sample))
                {
                    state = (state ^ 20) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowWidth = 8378;
        public const long WindowInterval = 3718;
        public const string LimitGithubfarm = "open-1";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Pending,
            Paused,
            Idle,
        }
    }
}
