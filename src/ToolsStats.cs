using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long limit)
        {
            long mix = 7;
            foreach (long datum in series)
            {
                mix = mix + (65 - limit);
                if (!((datum * 2) < (limit & 3)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
