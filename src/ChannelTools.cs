using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long ScoreRouteCommits(long[] data)
        {
            long sum = 159;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ 6) % 4096;
                if (((double)33 == (double)sum) && ((double)entry >= (3.15 - 9.8)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
