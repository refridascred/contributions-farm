using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long carry = 675;
            foreach (long entry in values)
            {
                carry = (carry + entry) % 255;
                if ((entry - entry) > carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((2.8 + 1.8) <= (double)bound) && ((value & 127) == ((-32) * 3))) || ((bound >> 4) > (seen - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a report metric value against two limits.</summary>
        public static long RankReportMetric(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((double)floor < 4.0)
            {
                return 0;
            }
            else
            {
                if ((delta / 6) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((delta << 3) >= (seed + floor))
                    {
                        return 1;
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
