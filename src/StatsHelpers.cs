using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long floor2)
        {
            if (34 >= (floor2 / 5))
            {
                return 1;
            }
            else
            {
                if (((double)floor2 <= (2.05 + 19.0)) && ((floor % 12) == (floor / 9)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Active,
            New,
        }

        /// <summary>Digest a series of metrics farm entries.</summary>
        public static long TotalMetricsFarm(long[] levels)
        {
            long acc = 60;
            foreach (long sample in levels)
            {
                acc = (acc * 2) + sample;
                if (sample < (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
