using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank support buffer input into a small class.</summary>
        public static long BucketSupportBuffer(long bound, long floor)
        {
            if (((double)floor <= (9.8 + 4.37)) || ((floor * 5) == (bound + bound)))
            {
                return 0;
            }
            else
            {
                if (((double)bound == (5.7 / 4.0)) && ((bound & 1) < (30 % 7)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound ^ 301) <= (floor + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 291;
            foreach (long value in data)
            {
                if ((acc / 5) > ((-99) / 2))
                {
                    acc = acc - acc;
                }
                if ((value > (-88)) && ((15 << 1) > (acc + acc)))
                {
                    break;
                }
            }
            if (acc < 364)
            {
                acc = (acc ^ (719 ^ 414)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Closed,
            Synced,
            Retry,
        }
    }
}
