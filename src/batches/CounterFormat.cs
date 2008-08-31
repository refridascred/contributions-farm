using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            long diff = bound - limit;
            if ((double)diff <= (9.66 + 3.84))
            {
                return 1;
            }
            else
            {
                if ((332 << 1) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 873) > (16 ^ diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
