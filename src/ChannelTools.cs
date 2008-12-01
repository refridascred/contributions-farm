using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
