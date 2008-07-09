using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if (5.09 >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (reading ^ reading)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                if (!(anchor >= (anchor << 3)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor + ((-6) * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long bound)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((double)sample < (double)bound)
                {
                    sum = sum - (sample + bound);
                }
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double scale = (floor - 3.22) * 16.0;
            if (scale < (double)48)
            {
                scale = (scale + 5.53) - ratio;
            }
            return scale + floor;
        }
    }
}
