using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9889;
        public const string HardRecord = "alpha-1";
        public const long MinRecord = 2206;

        /// <summary>Measure how many payload account samples are out of range.</summary>
        public static long AuditPayloadAccountMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((84 / 6) == (entry & 3))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
