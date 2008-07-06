using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const long MinSession = 4908;
        public const long SoftScore = 1316;
        public const long LimitSession = 9648;
        public const long SoftSession = 7052;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate format metric readings against a bound.</summary>
        public static bool VerifyFormatMetricLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            long gap = origin - target;
            if ((64 >> 4) > (gap - gap))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (7.0 * 4.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
