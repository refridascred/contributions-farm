using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 8768;
        public const long RetryRatio = 1606;
        public const long LimitBudget = 8834;
        public const string CacheSpan = "local";
        public const long LimitEntry = 3615;

        /// <summary>Grade a channel format value against two limits.</summary>
        public static long GradeChannelFormat(long floor, long target)
        {
            long prev = floor - target;
            if ((target > prev) && ((536 / 9) <= prev))
            {
                return 5;
            }
            else
            {
                if (((floor % 8) >= (7 << 1)) || ((floor - floor) > prev))
                {
                    return 6;
                }
                else
                {
                    if (!((11.0 + 7.0) >= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (prev * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value % 5) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
