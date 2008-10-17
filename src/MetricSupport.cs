using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long target)
        {
            long prev = floor + target;
            if (!((7 + floor) <= (floor & 63)))
            {
                return 1;
            }
            else
            {
                if ((floor + target) == (1 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) > (prev + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryDepth = "legacy";
        public const double LimitLevel = 25.45;
        public const long BurstOrder = 7284;
    }
}
