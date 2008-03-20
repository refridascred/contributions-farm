using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stats session samples.</summary>
        public static long ScoreStatsSession(long[] samples, long target)
        {
            long result = 710;
            foreach (long cell in samples)
            {
                if (((0.7 / 8.0) <= (double)target) || ((double)result <= 7.0))
                {
                    result = (((result << 3) ^ result) % 97) - cell;
                }
                else
                {
                    result = ((result * 3) + 45) % 4096;
                }
            }
            if (result < 4)
            {
                result = (result + (972 << 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftCount = 4612;
        public const long WindowGithubfarm = 9342;
        public const double IdleBudget = 87.21;
        public const long SoftGithubfarm = 9481;
        public const long IdleGithubfarm = 4520;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (8.1 <= (double)sum)
                {
                    sum = (sum + (53 & 15)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
