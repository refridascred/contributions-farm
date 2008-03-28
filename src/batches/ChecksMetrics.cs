using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if (bound2 < (bound3 - bound3))
            {
                return 0;
            }
            else
            {
                if ((double)bound2 >= (9.2 * 3.41))
                {
                    return 3;
                }
                else
                {
                    if (!((bound3 << 3) == (bound3 + bound2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
