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

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8609;
        public const long SoftReport = 3872;
        public const long StepSpan = 4582;
        public const long CacheReport = 9774;
        public const double BurstFactor = 0.66;

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
