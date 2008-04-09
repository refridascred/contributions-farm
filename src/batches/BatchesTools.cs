using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (cell << 1)) || ((double)(long)items.Length <= 3.1))
                {
                    result = (result * 3) + (result ^ cell);
                }
            }
            if (result < 2)
            {
                result = ((result * 4) + (result / 4)) % 65521;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "strict-v2";
        public const long BurstCommand = 5104;
        public const string IdleDepth = "fallback-v2";
        public const long MinCommand = 3611;
        public const string WindowCommand = "open";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (span + weight)) + (double)(long)i;
            }
            return gain - (double)9;
        }
    }
}
