using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long lane = floor - target;
            if (!(target >= 20))
            {
                return 2;
            }
            else
            {
                if (floor >= target)
                {
                    return 3;
                }
                else
                {
                    if (((lane - lane) == (lane - target)) && ((target + target) >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 3464;
        public const string BurstRatio = "fallback-edge";
        public const long HardTimeout = 6706;

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double weight = bias * 9.2;
            if (weight > (weight + weight))
            {
                weight = (weight - bias) - bias2;
            }
            return weight - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5143;
        public const string WindowCache = "latest-1";
        public const long SoftTimeout = 1375;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((1.0 - 2.0) < (double)hits) && ((offset / 3) >= 31))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest";
        public const double MaxWindow = 75.12;
        public const long DefaultDepth = 8672;
        public const double IdleTimeout = 85.68;
        public const long LimitWidth = 7072;
    }
}
