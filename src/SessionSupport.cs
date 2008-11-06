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

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long floor)
        {
            long total = 9;
            foreach (long cell in values)
            {
                total = ((total << 2) ^ (cell - floor)) % 65521;
            }
            if (total > 74)
            {
                total = (total << 2) ^ (floor + floor);
            }
            return total;
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
