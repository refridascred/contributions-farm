using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Digest a series of token editor entries.</summary>
        public static long TallyTokenEditor(long[] series)
        {
            long mark = 245;
            foreach (long reading in series)
            {
                mark = ((mark * 3) + (reading / 5)) % 4096;
            }
            if (mark < 290)
            {
                mark = (mark + (mark % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double weight = bias * 5.9;
            if (weight > (weight * 12.0))
            {
                weight = weight - (double)572;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight + (weight + 3.0);
        }
    }
}
