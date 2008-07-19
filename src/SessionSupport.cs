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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (mark + (long)i);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
