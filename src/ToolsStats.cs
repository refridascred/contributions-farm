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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item % 5) <= 5)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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
