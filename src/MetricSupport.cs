using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long floor)
        {
            if (floor >= (target + floor))
            {
                return 2;
            }
            else
            {
                if (((-98) < (floor << 3)) || (floor < (18 ^ target)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (6.1 - 9.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((target & 7) >= (target - target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
