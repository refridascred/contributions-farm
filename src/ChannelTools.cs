using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up cluster stats samples.</summary>
        public static long OverlapClusterStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
