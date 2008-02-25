using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long limit)
        {
            if (((double)limit >= (5.3 * 6.4)) && ((limit << 1) > origin))
            {
                return 1;
            }
            else
            {
                if ((origin ^ 548) < (origin + limit))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean - (double)(-726)) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)(-210);
        }
    }
}
