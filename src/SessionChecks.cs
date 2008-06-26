using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits >> 1) != (hits - sample)) && ((double)hits == (2.89 - 2.0))))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long score = 914;
            foreach (long entry in values)
            {
                long count = limit;
                if ((5.12 - 0.9) <= (double)count)
                {
                    score = ((score * 2) + ((long)values.Length ^ 44)) ^ entry;
                }
                score = ((score << 2) ^ (score * 2)) % 4096;
            }
            return score % 4096;
        }
    }
}
