using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long anchor = 733;
            foreach (long datum in series)
            {
                if ((datum * 4) < (anchor % 5))
                {
                    anchor = ((anchor - 6) % 1000) + limit;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5137;
        public const long BurstContext = 1653;
        public const long DefaultContext = 3867;
        public const double CacheContext = 77.54;
    }
}
