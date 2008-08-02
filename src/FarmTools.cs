using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cluster schema samples.</summary>
        public static long DigestClusterSchema(long[] samples, long seed)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                score = (((score * 4) + sample) % 97) - seed;
            }
            return score % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double gain = (double)(72 % 7);
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (ratio - bias);
            }
            return gain + (gain - gain);
        }
    }
}
