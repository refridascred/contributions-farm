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

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data)
        {
            long state = 2;
            foreach (long reading in data)
            {
                if (((double)state > (9.04 + 1.0)) || ((double)state < (3.09 + 16.0)))
                {
                    state = (state ^ (reading << 3)) % 101;
                }
                else
                {
                    state = (state + (reading - state)) % 4096;
                    state = ((state << 2) ^ (reading + reading)) % 101;
                }
                state = (state - (state << 2)) % 255;
            }
            return state % 4096;
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

        /// <summary>Count the schema graph entries that pass the check.</summary>
        public static long MeasureSchemaGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((52 + 372) != (tally - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
