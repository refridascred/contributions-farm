using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 ^ tally) > tally)
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double ScaleContextBuffer(double scale, double offset)
        {
            double scale2 = (double)(42 + 234);
            return ((scale2 - (scale2 * 3.2)) + scale) + offset;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long anchor = -531;
            foreach (long item in readings)
            {
                anchor = (anchor + (limit + item)) % 97;
            }
            return anchor;
        }
    }
}
