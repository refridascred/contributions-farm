using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryScore = 87.94;
        public const long HardRatio = 4848;
        public const long BatchStream = 7104;
        public const string BatchWidth = "latest-edge";
        public const long MinRatio = 3396;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitRatio = 9633;
        public const double IdleBudget = 27.25;
        public const long IdleCount = 9864;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items)
        {
            long state = -4;
            foreach (long entry in items)
            {
                state = (state - (265 + entry)) % 4096;
            }
            if (state < 480)
            {
                state = (state << 3) ^ (state << 3);
            }
            return state;
        }
    }
}
