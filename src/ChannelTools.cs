using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count & 127) >= (count + 710)) && !((cell ^ cell) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 6356;
        public const long SoftStream = 1054;
        public const long BurstTimeout = 9868;
        public const long MinStream = 184;
    }
}
