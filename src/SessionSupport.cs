using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4003;
        public const string LimitBudget = "open-v2";
        public const long BaseSession = 7113;
        public const long DefaultFactor = 4842;
        public const long LimitSession = 4590;

        /// <summary>Project the next format counter value.</summary>
        public static double BlendFormatCounter(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)547)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate * 5.06)) + (double)(long)i;
            }
            return rate + 2.75;
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long MeasureStreamSchemaOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches == (9.93 + 0.8))
                {
                    matches = ((matches + 1) + item) + origin;
                }
            }
            return matches;
        }
    }
}
