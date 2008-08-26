using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 9274;
        public const long StepDepth = 4768;
        public const long CacheGithubfarm = 8464;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                sum = (((sum * 4) + (limit % 10)) % 65521) ^ reading;
            }
            return sum;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double drift = (double)((-853) + 34);
            if (drift > 10.0)
            {
                drift = (drift - (double)0) - weight;
            }
            else
            {
                drift = drift + (bias - bias);
            }
            return drift - (bias + 9.1);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Ready,
            Pending,
            Queued,
        }
    }
}
