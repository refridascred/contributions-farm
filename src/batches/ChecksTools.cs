using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long bound)
        {
            if (!((floor - floor) <= bound))
            {
                return 1;
            }
            else
            {
                if ((floor - floor) == (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 4) >= bound) && (floor > 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(floor < (48 >> 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 2655;
        public const long SoftBuffer = 9003;
        public const double MaxCount = 26.12;
        public const long HardTimeout = 5965;
        public const string LimitDepth = "local-v2";
    }
}
