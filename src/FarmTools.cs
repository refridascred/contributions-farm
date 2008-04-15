using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long ClassifyChecksFormat(long limit, long origin)
        {
            if (!((origin & 1) < (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (4.0 + 0.21))
                {
                    return 2;
                }
                else
                {
                    if ((6.77 + 3.18) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 5530;
        public const string CacheChannel = "cached-1";
        public const long BatchScore = 7578;
        public const long MaxChannel = 276;
        public const long BurstChannel = 1566;
    }
}
