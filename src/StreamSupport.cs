using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 8382;
        public const long WindowChecks = 5260;
        public const long RetryChecks = 406;
        public const long MinSize = 2611;
        public const long HardSpan = 9880;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total + (floor / 3);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (ratio * 9.94)) + (double)(long)i) + scale;
            }
            return ratio - (double)(-229);
        }
    }
}
