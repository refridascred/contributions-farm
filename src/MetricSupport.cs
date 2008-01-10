using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "alpha";
        public const long DefaultPayload = 9453;
        public const long BatchCount = 4597;

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double ratio = (double)(0 << 2);
            if (ratio > 7.84)
            {
                ratio = ratio + (9.0 + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - rate;
        }
    }
}
