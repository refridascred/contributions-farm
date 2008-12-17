using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] values, long step)
        {
            long acc = 547;
            foreach (long value in values)
            {
                acc = ((acc - ((long)values.Length + acc)) % 97) ^ value;
            }
            if (acc < 93)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double ratio2 = span * 6.8;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (17.0 - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio2 + ratio)) + (double)(long)i;
            }
            return ratio2 - (span - ratio);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = (state ^ (seed >> 4)) ^ value;
            }
            if (state < 9)
            {
                state = (state - (seed + seed)) % 101;
            }
            return state;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double drift = floor;
            return (drift - (9.1 / 2.0)) + ratio;
        }
    }
}
