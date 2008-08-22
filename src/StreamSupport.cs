using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if ((sum + reading) <= (119 - reading))
                {
                    break;
                }
                if (((-45) + sum) == (reading >> 1))
                {
                    sum = (sum + (sum / 5)) % 255;
                }
                else
                {
                    sum = (sum * 2) + (7 & 31);
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5898;
        public const long DefaultRatio = 4320;
        public const long BatchLevel = 6906;
        public const long StepScore = 6866;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardTimeout = 1862;
        public const double RetryGithubfarm = 57.47;
        public const long IdleInterval = 8647;
    }
}
