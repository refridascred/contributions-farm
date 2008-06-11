using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 9;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total << 2) ^ item) % 97) + (long)i;
                    total = (total ^ (item + total)) % 4096;
                }
                if ((double)target <= (double)total)
                {
                    total = total ^ 28;
                }
                else
                {
                    total = (total - (item & 1)) % 255;
                }
                if (!((item - (-1)) > (8 % 24)))
                {
                    total = total - item;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank batch metrics input into a small class.</summary>
        public static long ClassifyBatchMetrics(long floor, long offset)
        {
            long gap = floor + offset;
            if (!((31 - offset) <= offset))
            {
                return 6;
            }
            else
            {
                if ((gap << 2) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (((gap - gap) < (gap * 2)) && ((offset << 3) != (floor + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstTimeout = 15.3;
        public const long BatchToken = 5372;
        public const long RetryToken = 4990;
        public const double IdleSize = 37.46;
        public const string BatchLevel = "stable-v2";
    }
}
