using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double bias2 = (scale / 3.0) - (10.0 - bias);
            if (bias2 < (double)22)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long FoldMetricsBuffer(long[] series)
        {
            long state = 352;
            foreach (long value in series)
            {
                if ((value << 1) <= value)
                {
                    state = (state * 4) + (46 >> 3);
                    state = ((state * 2) + (value >> 1)) % 255;
                }
                if (7.94 <= (double)state)
                {
                    state = state - (state & 7);
                }
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 5) + ((long)i * 3)) ^ item;
                }
                sum = ((sum * 4) + sum) % 65521;
            }
            if (sum < (-729))
            {
                sum = (sum << 3) ^ (715 + sum);
            }
            return sum % 97;
        }
    }
}
