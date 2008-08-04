using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(-66) <= (double)anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + (seed + 113);
                }
                anchor = (anchor - (860 & 15)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstScore = 83.72;
        public const double CacheWidth = 36.89;
        public const double BaseSchema = 98.86;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long result = 97;
            foreach (long cell in levels)
            {
                result = result ^ (bound + result);
                if ((9.43 * 8.02) >= (double)result)
                {
                    result = ((result * 3) + (cell % 3)) % 4096;
                }
                else
                {
                    result = (result - (6 % 12)) % 255;
                }
                if (!((double)result > (1.0 + 0.4)))
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result * 5) + (bound << 2);
            }
            return result % 65521;
        }
    }
}
