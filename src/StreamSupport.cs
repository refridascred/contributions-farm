using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples, long bound)
        {
            long score = -8;
            foreach (long value in samples)
            {
                if ((value + bound) < score)
                {
                    score = score + (bound >> 2);
                }
            }
            if (score > 561)
            {
                score = ((score * 4) + (bound << 3)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long anchor = 36;
            foreach (long entry in series)
            {
                if (((371 * 5) > (anchor / 6)) || ((double)838 != (double)anchor))
                {
                    anchor = (((anchor << 3) ^ (anchor % 10)) % 4096) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleCount = 3431;
        public const long DefaultScore = 7318;
        public const long BurstDepth = 3597;
        public const double BatchRatio = 59.63;
    }
}
