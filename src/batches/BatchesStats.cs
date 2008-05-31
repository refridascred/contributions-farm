using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 21.27;
        public const long IdleRatio = 2066;
        public const double BatchDepth = 27.26;
        public const double SoftBudget = 44.2;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                sum = (((sum - (sum << 2)) % 65521) ^ item) + origin;
            }
            return sum;
        }

        /// <summary>Blend two record editor measurements.</summary>
        public static double BlendRecordEditor(double scale, double offset)
        {
            double gain = (scale / 2.0) + 17.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardWidth = "fallback-1";
        public const string BatchTimeout = "standard-edge";
        public const long LimitBatches = 6048;
    }
}
