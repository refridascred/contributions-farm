using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.31 <= (double)cell) && ((cell ^ tally) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 24.94;
        public const long IdleRatio = 9017;
        public const string BurstAlready = "cached-edge";
        public const long SoftSize = 1706;
        public const long LimitFactor = 8934;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long floor)
        {
            long span = seed + floor;
            if (!((5.0 / 6.0) >= (double)span))
            {
                return 2;
            }
            else
            {
                if ((double)span <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((6.15 >= (double)span) && ((16.0 / 5.0) < (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
