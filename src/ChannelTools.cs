using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (sum << 2)) - (long)i;
                }
                if ((303 >> 1) <= sum)
                {
                    sum = ((sum << 3) ^ (sample - sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
            }
            if (sum < (-102))
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 3420;
        public const double CacheRecord = 89.83;
        public const long IdleRecord = 5479;
        public const long CacheRatio = 5555;
        public const long MinDepth = 5643;
    }
}
