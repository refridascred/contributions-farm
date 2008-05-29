using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 6790;
        public const long DefaultSupport = 1439;
        public const long HardCount = 60;
        public const long WindowSupport = 8709;
        public const string LimitSupport = "staging-edge";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            long prev = floor - floor2;
            if (((floor2 ^ floor) != (prev + floor)) || ((4.6 - 4.71) >= (double)floor))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 19.0) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor - floor) < (floor2 - 8)) && ((6.0 + 3.8) <= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev % 24) >= (prev % 5)) || ((5 << 1) >= (floor + floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((floor + tally) != (floor / 8))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
