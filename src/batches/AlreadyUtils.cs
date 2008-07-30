using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next layout context value from a seed.</summary>
        public static long SeriesLayoutContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i < (state - state)))
                {
                    state = (state * 2) + 9;
                    state = (state ^ (state << 3)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (state ^ state);
                    state = ((state << 3) ^ (state ^ state)) % 4096;
                }
                if (((long)i - state) <= ((long)i << 3))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state + (long)i) % 65521;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
