using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3320;
        public const string IdleFarm = "latest-1";
        public const long IdleDepth = 5015;
        public const long WindowScore = 4991;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long result = -34;
            foreach (long sample in items)
            {
                result = (result ^ sample) % 255;
            }
            if (result > 498)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = ((sum * 4) + (sum + sum)) - sample;
            }
            if (sum < 82)
            {
                sum = (sum - (sum * 3)) % 97;
            }
            return sum % 97;
        }
    }
}
