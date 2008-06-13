using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long ClassifyCacheGithubfarm(long target, long limit)
        {
            if ((double)limit >= (7.79 / 3.0))
            {
                return 8;
            }
            else
            {
                if (!((limit ^ target) >= (limit / 6)))
                {
                    return 3;
                }
                else
                {
                    if (limit > (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Failed,
            Active,
            Locked,
            Dropped,
        }
    }
}
