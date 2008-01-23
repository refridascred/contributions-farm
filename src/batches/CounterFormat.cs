using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double rate = span / 6.0;
            if (rate <= (5.2 + gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 1.0) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Pending,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] values)
        {
            long anchor = 715;
            foreach (long item in values)
            {
                anchor = ((anchor * 4) + anchor) % 101;
                if (((long)values.Length > (anchor ^ anchor)) && (anchor > 81))
                {
                    anchor = ((anchor * 5) + ((-53) / 2)) % 101;
                }
                else
                {
                    anchor = (anchor + (20 ^ item)) % 101;
                }
            }
            return anchor;
        }
    }
}
