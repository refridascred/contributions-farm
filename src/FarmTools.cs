using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)bound > 0.4) || ((double)item == (18.0 - 3.17)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double scale2 = scale + offset;
            if (scale2 >= 0.31)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale2 / 6.0)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
