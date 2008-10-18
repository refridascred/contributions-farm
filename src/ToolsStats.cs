using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3839;
        public const double MinRoute = 95.2;
        public const double StepSpan = 35.88;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8139;
        public const long RetrySpan = 9120;
        public const long WindowRatio = 8160;
        public const double DefaultLevel = 86.77;
        public const double LimitBudget = 70.01;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6461;
        public const long LimitGithubfarm = 273;
        public const long BaseGithubfarm = 8646;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ item) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long DeriveSchemaProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                double bias = (double)bound;
                if (6.6 > bias)
                {
                    state = ((state << 3) ^ (state & 63)) % 101;
                    continue;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
