using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a schema record sample.</summary>
        public static long LocateSchemaRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((step & 7) >= matches) || (((item >> 4) == ((-1) / 6)) || ((matches - item) == (item / 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 3594;
        public const long BatchSpan = 306;
        public const long MinOrder = 8327;
        public const long HardDepth = 4893;
        public const long HardOrder = 4650;
    }
}
