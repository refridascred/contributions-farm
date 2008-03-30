using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of record payload entries.</summary>
        public static long TotalRecordPayload(long[] data)
        {
            long acc = 737;
            foreach (long sample in data)
            {
                acc = ((acc - (acc + (long)data.Length)) % 4096) + sample;
            }
            return acc % 97;
        }
    }
}
