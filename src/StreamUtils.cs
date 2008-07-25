using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Paused,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long bound)
        {
            if (((8.0 / 2.0) <= (double)bound) && ((1.8 / 6.0) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((target / 2) != (target << 1))
                {
                    return 0;
                }
                else
                {
                    if ((bound < (target % 5)) || ((target & 31) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitLevel = 55.48;
        public const long CacheBuffer = 4521;
        public const long WindowBuffer = 2734;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
