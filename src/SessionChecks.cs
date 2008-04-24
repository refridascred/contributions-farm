using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a queue commits counter forward.</summary>
        public static long IterateQueueCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ (534 - floor);
                state = ((state << 2) ^ (floor & 3)) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long MatchContextReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Pending,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double mean = 9.6 - (double)(-85);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (gain * 3.16)) + (double)(long)i) - span;
            }
            return mean - (8.0 + mean);
        }
    }
}
