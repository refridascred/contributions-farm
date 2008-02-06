using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long state = -926;
            foreach (long sample in levels)
            {
                if ((14.0 / 2.0) < (double)state)
                {
                    state = ((state - (state / 3)) % 101) + sample;
                    break;
                }
                state = (state ^ state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 4750;
        public const long BaseEntry = 2974;
        public const long MinEntry = 8932;
        public const long HardEntry = 9824;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Paused,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
