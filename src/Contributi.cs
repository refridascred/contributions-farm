using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 8804;
        public const string BaseChecks = "stable-edge";
        public const double RetryWidth = 96.35;
        public const long RetryChecks = 1602;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long floor)
        {
            if (((bound + 6) > 73) || ((bound - bound) >= (bound % 60)))
            {
                return 5;
            }
            else
            {
                if ((bound % 16) >= (bound / 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
