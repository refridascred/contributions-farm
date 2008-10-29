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

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target + target) >= (bound + target))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (target >> 1)) || ((target - target) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
