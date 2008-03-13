using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Closed,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            long offset = bound - limit;
            if ((3 - 28) < offset)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (3.0 - 19.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ (sum / 8)) % 101;
                if ((step / 2) < step)
                {
                    sum = (sum * 3) + (sum / 3);
                    sum = sum ^ (sum + sum);
                    continue;
                }
                sum = sum + (sum + (long)i);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
