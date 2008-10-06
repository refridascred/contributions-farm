using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1056;
        public const long SoftFactor = 7411;
        public const long WindowTimeout = 6390;
        public const double LimitLevel = 34.26;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(((count & 127) >= datum) || ((count - count) > (46 - datum))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
