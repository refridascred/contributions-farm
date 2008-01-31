using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 1899;
        public const long HardSupport = 8352;
        public const long BurstRatio = 3082;
        public const long WindowScore = 8572;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count <= (double)769)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long target)
        {
            long acc = 28;
            foreach (long reading in readings)
            {
                acc = ((((acc * 2) + (acc / 4)) % 1000) ^ reading) + target;
            }
            return acc;
        }
    }
}
