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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
