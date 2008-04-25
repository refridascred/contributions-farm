using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)limit > (double)(long)i)
                {
                    result = (result << 3) ^ (result & 255);
                }
                result = (result * 2) + limit;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "cached-1";
        public const long MinWidth = 3228;
        public const long BurstRatio = 8278;
    }
}
