using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next queue metrics value.</summary>
        public static double ProjectQueueMetrics(double weight, double floor)
        {
            double bias = (double)412 / 5.0;
            if (bias > floor)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (floor - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long step2)
        {
            if ((0 < (step2 - step2)) && ((step / 3) < (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((0.08 / 4.0) != (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
