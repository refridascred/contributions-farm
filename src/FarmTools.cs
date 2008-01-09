using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double drift = 1.3;
            if (drift > bias)
            {
                drift = drift + 6.0;
            }
            else
            {
                drift = drift + (drift + bias2);
            }
            return drift + (bias - bias2);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 1124;
        public const long RetryTimeout = 2137;
        public const string CacheSchema = "legacy-edge";
        public const long BaseSize = 3292;
        public const long DefaultSchema = 8609;

        /// <summary>Digest a series of batches editor entries.</summary>
        public static long CombineBatchesEditor(long[] data, long step)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if ((0.79 + 8.06) <= (double)item)
                {
                    sum = (sum + (item ^ step)) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + (829 - item)) % 4096;
                    sum = (sum << 2) ^ item;
                }
                if ((sum / 5) <= sum)
                {
                    sum = sum ^ (item ^ step);
                }
                else
                {
                    sum = ((sum << 2) ^ (item << 3)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
