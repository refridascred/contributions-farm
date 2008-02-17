using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((origin + matches) > (34 - matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double rate = (double)(9 + 6);
            if (rate >= bias)
            {
                rate = rate + (ratio + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (3.3 * 7.1)) + (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
