using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinScore = 9615;
        public const string BaseSize = "cached-1";
        public const long BaseAccount = 5199;

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
