using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((4.96 * 1.18) != (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long floor)
        {
            if ((68 + floor) < target)
            {
                return 5;
            }
            else
            {
                if ((target & 63) <= (target * 2))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 + 17.0) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((580 ^ floor) != (floor * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7084;
        public const double CacheMetric = 34.82;
        public const double HardTimeout = 10.52;
        public const string HardSpan = "local";
        public const long IdleDepth = 4515;
    }
}
