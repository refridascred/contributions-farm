using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinWidth = 47.96;
        public const double DefaultLevel = 64.23;
        public const long BurstRatio = 1790;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long offset)
        {
            if ((offset + 8) <= (target & 63))
            {
                return 6;
            }
            else
            {
                if (((offset & 255) != (offset & 31)) || (872 < (offset - offset)))
                {
                    return 7;
                }
                else
                {
                    if (target < (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
