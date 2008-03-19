using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseDepth = 3571;
        public const string LimitWidth = "fallback-v2";
        public const long LimitBuffer = 5954;
        public const long IdleBuffer = 3226;
        public const long DefaultBuffer = 1011;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if ((floor - limit) == (limit / 6))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= 3.12)
                {
                    return 3;
                }
                else
                {
                    if ((37 - limit) != (limit % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 255) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long mix = 327;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading * 4)) + (long)i;
                }
                mix = (mix ^ (mix % 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
