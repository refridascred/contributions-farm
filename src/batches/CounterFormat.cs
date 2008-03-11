using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double ratio2 = (ratio / 7.0) + ratio;
            if (ratio2 < (ratio - 6.14))
            {
                ratio2 = ratio2 + (double)6;
            }
            return ratio2 - (bias - bias);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Pending,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long CountOrderCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value - seen) <= (value ^ value)) || ((7.0 + 8.27) != (double)value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
