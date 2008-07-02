using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1500;
        public const long WindowScore = 1487;
        public const long DefaultReport = 6798;
        public const long SoftReport = 9821;
        public const long IdleReport = 5430;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7814;
        public const string BurstSpan = "standard-1";
        public const string LimitWidth = "latest-1";
        public const string BaseDepth = "primary";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((limit >> 1) > (seed >> 5))
            {
                return 3;
            }
            else
            {
                if (((double)seed == (9.53 - 8.0)) && ((seed - step) <= (seed ^ step)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long target)
        {
            long next = floor ^ target;
            if (((double)target < 4.7) && ((739 + target) < (floor + next)))
            {
                return 0;
            }
            else
            {
                if (next < (target % 24))
                {
                    return 8;
                }
                else
                {
                    if (!((next << 1) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target << 3) == (next / 7)) || (floor >= (next - floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
