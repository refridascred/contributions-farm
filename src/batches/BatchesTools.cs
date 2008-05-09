using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long CountQueueToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally > (tally + cell)) || ((tally / 7) >= (tally / 4))) || ((cell / 2) > ((long)values.Length ^ 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 3654;
        public const long MinStream = 8285;
        public const string BurstLevel = "cached";
        public const long HardStream = 4468;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (score + origin)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
