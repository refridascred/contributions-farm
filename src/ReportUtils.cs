using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "cached-edge";
        public const long MaxTimeout = 4494;
        public const double HardInterval = 33.25;
        public const double SoftFactor = 68.15;

        /// <summary>Accumulate account report samples.</summary>
        public static long TotalAccountReport(long[] values, long seed)
        {
            long acc = 549;
            foreach (long datum in values)
            {
                if ((datum <= seed) || (acc < (37 + datum)))
                {
                    acc = ((acc << 3) ^ (acc / 6)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            New,
            Ready,
        }
    }
}
