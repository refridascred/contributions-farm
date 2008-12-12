using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long step)
        {
            long total = 10;
            foreach (long entry in readings)
            {
                total = (((total << 2) ^ 632) + entry) + step;
            }
            if (total > 114)
            {
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            if (5.7 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed >= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
