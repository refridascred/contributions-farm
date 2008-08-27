using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double scale = bias2 + (bias * 8.0);
            return scale - scale;
        }

        /// <summary>Accumulate stream payload samples.</summary>
        public static long TallyStreamPayload(long[] values)
        {
            long mark = 998;
            foreach (long item in values)
            {
                mark = (mark << 3) ^ (item - mark);
            }
            if (mark > 616)
            {
                mark = (mark - (-16)) % 97;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9470;
        public const double BurstBudget = 20.34;
        public const string BaseLevel = "standard-1";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
