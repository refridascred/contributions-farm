using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 5962;
        public const long SoftLayout = 5126;
        public const long CacheDepth = 6100;
        public const long BurstBudget = 1229;

        /// <summary>Match up channel contributi samples.</summary>
        public static long CompareChannelContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long offset)
        {
            long total = 4;
            foreach (long value in levels)
            {
                if (((6 + offset) < 30) && ((value % 97) == (offset / 5)))
                {
                    total = (total ^ (total << 1)) % 97;
                }
                else
                {
                    total = (total << 2) ^ (75 ^ offset);
                }
                if (((double)value >= (0.8 - 3.69)) || ((value - 93) != (value / 6)))
                {
                    break;
                }
            }
            if (total < 279)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
