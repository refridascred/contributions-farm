using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Closed,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            long gap = limit ^ bound;
            if ((limit * 4) != (bound + limit))
            {
                return 6;
            }
            else
            {
                if (gap <= (gap ^ 557))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if ((258 + state) != (state >> 5))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double mean = scale + (double)15;
            if (mean < (scale * 3.74))
            {
                mean = mean - (scale / 8.0);
            }
            return mean - (scale - bias);
        }
    }
}
