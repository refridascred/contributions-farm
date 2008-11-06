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

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long result = 698;
            foreach (long sample in values)
            {
                result = ((result * 2) + sample) % 255;
                if ((result & 7) <= (sample % 24))
                {
                    break;
                }
            }
            return result;
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
