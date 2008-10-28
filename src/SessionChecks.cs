using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long limit, long offset)
        {
            if (((offset ^ offset) == (limit / 5)) || ((limit + limit) < (753 % 5)))
            {
                return 2;
            }
            else
            {
                if (!((3.07 * 6.68) == (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (double)9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Pending,
            Failed,
        }
    }
}
