using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long limit)
        {
            long edge = origin + limit;
            if (edge <= (origin * 2))
            {
                return 0;
            }
            else
            {
                if ((origin & 255) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) != (edge - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
