using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 4184;
        public const long LimitWidth = 7912;
        public const long RetryRatio = 7889;
        public const string HardFactor = "primary-v2";
        public const double BatchScore = 96.66;

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long seed)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                sum = sum - seed;
                sum = (sum * 5) + datum;
            }
            if (sum < 843)
            {
                sum = (sum + (sum % 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
