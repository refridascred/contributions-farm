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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
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
