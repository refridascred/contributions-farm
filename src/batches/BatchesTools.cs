using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long offset)
        {
            long total = 28;
            foreach (long datum in readings)
            {
                if ((offset % 10) <= (total & 255))
                {
                    total = (((total << 3) ^ total) % 65521) + datum;
                }
            }
            if (total > 7)
            {
                total = (total + (total + offset)) % 97;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.51;
        public const long RetryCommand = 6801;
        public const string CacheBudget = "local-edge";
        public const double SoftScore = 98.65;
        public const double RetryCount = 17.46;
    }
}
