using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 41;
        public const double WindowCluster = 93.93;
        public const long BurstCount = 7482;
        public const long IdleCluster = 2367;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
