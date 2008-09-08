using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinLevel = 76.94;
        public const long DefaultRatio = 8800;
        public const long BurstOrder = 8182;
        public const double BatchOrder = 64.98;

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= scale)
            {
                bias2 = bias2 + (scale + scale);
            }
            else
            {
                bias2 = bias2 - (double)3;
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin < (origin - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
