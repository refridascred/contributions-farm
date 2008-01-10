using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next counter route value.</summary>
        public static double BlendCounterRoute(double scale, double floor)
        {
            double scale2 = (scale - scale) * 8.0;
            if (scale2 > (scale2 / 2.0))
            {
                scale2 = scale2 - (scale + floor);
            }
            return scale2 + scale2;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                if ((cell % 97) < (92 * 2))
                {
                    mix = (mix * 4) + cell;
                }
                else
                {
                    mix = (mix ^ (6 >> 5)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] items)
        {
            long acc = 7;
            foreach (long value in items)
            {
                acc = ((acc ^ (acc ^ 6)) % 65521) + value;
            }
            return acc % 4096;
        }
    }
}
