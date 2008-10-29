using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4840;
        public const string StepDepth = "primary-v2";
        public const long HardMetrics = 6527;
        public const long LimitMetrics = 8577;
        public const long CacheRatio = 4183;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 2) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long bound)
        {
            long lane = seed + bound;
            if ((bound & 63) < lane)
            {
                return 8;
            }
            else
            {
                if ((lane + bound) < (seed - 1))
                {
                    return 4;
                }
                else
                {
                    if ((0.2 * 3.87) <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.54 * 19.0) >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (20.0 * 4.01))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data, long origin)
        {
            long result = 974;
            foreach (long value in data)
            {
                result = (((result << 3) ^ (origin - origin)) % 97) ^ value;
            }
            if (result < 570)
            {
                result = (result << 2) ^ (result << 1);
            }
            return result % 97;
        }
    }
}
