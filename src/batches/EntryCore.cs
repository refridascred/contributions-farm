using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (slot < (51 << 1))
            {
                return 5;
            }
            else
            {
                if ((bound2 - bound) >= (bound2 - bound2))
                {
                    return 0;
                }
                else
                {
                    if ((slot + 85) >= 132)
                    {
                        return 1;
                    }
                    else
                    {
                        if (slot >= (slot * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ origin) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Active,
            New,
            Idle,
            Failed,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
