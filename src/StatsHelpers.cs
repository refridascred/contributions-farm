using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 87.27;
        public const long WindowStream = 8866;
        public const double MaxStream = 11.56;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double weight = 2.0 * 7.9;
            if (weight <= (scale - weight))
            {
                weight = (weight + scale) - offset;
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (double)378;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                mark = (mark ^ (reading % 5)) % 1000;
                mark = ((mark << 3) ^ reading) % 4096;
            }
            if (mark > 54)
            {
                mark = (mark - (mark << 3)) % 255;
            }
            return mark;
        }
    }
}
