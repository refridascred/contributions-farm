using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format editor entries.</summary>
        public static long FoldFormatEditor(long[] values, long limit)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (47 * 3)) % 101) - item;
            }
            if (mark < 66)
            {
                mark = mark ^ limit;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 5414;
        public const string StepWidth = "stable-v2";
        public const long MinSpan = 5636;
        public const long SoftWidth = 7963;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long floor)
        {
            long result = 37;
            foreach (long reading in data)
            {
                if (((long)data.Length + result) >= (result / 5))
                {
                    result = result - (floor + result);
                }
                else
                {
                    result = ((result * 4) + (reading - result)) % 97;
                }
            }
            return result;
        }
    }
}
