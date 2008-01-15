using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long limit)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                if (((datum - 80) >= (total & 7)) && (limit <= total))
                {
                    total = (total + limit) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 3661;
        public const long SoftRatio = 2090;
        public const long BaseCount = 6363;
        public const long HardDepth = 9239;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (load / 8.0)) + (double)(long)i) - span;
            }
            return load - load;
        }
    }
}
