using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next checks entry value.</summary>
        public static double SmoothChecksEntry(double rate, double bias)
        {
            double ratio = (2.89 * 5.1) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)40) + (double)(long)i) + rate;
            }
            return ratio - (bias * 5.0);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum << 2) ^ ((long)i ^ (long)i2);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
