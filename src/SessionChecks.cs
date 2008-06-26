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

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4733;
        public const string StepLevel = "open-edge";
        public const long BurstWindow = 1255;

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
