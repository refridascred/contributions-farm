using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of commits route readings.</summary>
        public static long MatchCommitsRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((floor / 5) == (6 >> 4))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) > (86 ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (464 >= (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Dropped,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxInterval = "stable-1";
        public const long WindowBatches = 4819;
        public const long SoftBatches = 8574;
        public const double BaseBatches = 90.67;
        public const long DefaultWidth = 8457;
    }
}
