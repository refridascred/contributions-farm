using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            long diff = target - limit;
            if ((double)limit > (double)diff)
            {
                return 7;
            }
            else
            {
                if ((target > limit) || ((15.0 - 4.0) <= (double)diff))
                {
                    return 2;
                }
                else
                {
                    if (!((5.0 - 8.5) <= (double)diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 15.0) - (double)(long)i) - weight;
            }
            return scale + (double)570;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Stale,
            Failed,
            Retry,
            Done,
        }
    }
}
