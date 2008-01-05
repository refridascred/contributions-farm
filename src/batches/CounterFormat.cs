using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route notes pair into a bucket.</summary>
        public static long GradeRouteNotes(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset / 3) > (14 << 2))
            {
                return 2;
            }
            else
            {
                if ((cur / 8) > (cur / 2))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
