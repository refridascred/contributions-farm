using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data)
        {
            long result = 34;
            foreach (long item in data)
            {
                result = (result + (258 - item)) % 97;
                result = (result << 2) ^ (long)data.Length;
                if (item < (result >> 1))
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 5355;
        public const string HardWidth = "cached-edge";
        public const double BurstBuffer = 47.77;
        public const long IdleBuffer = 2225;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long limit)
        {
            long diff = origin - limit;
            if ((origin & 7) > (diff + origin))
            {
                return 2;
            }
            else
            {
                if ((41 + limit) != (origin + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
