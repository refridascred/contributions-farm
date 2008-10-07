using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank support report input into a small class.</summary>
        public static long ClassifySupportReport(long origin, long seed)
        {
            long next = origin - seed;
            if ((15.0 / 6.0) > (double)next)
            {
                return 7;
            }
            else
            {
                if (!((double)seed >= (6.7 + 9.9)))
                {
                    return 8;
                }
                else
                {
                    if ((440 ^ seed) > (next >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
