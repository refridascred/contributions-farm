using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 1407;
        public const string BaseToken = "fallback-1";
        public const long BurstToken = 7554;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                mark = ((mark - mark) ^ reading) - limit;
                mark = (mark + (416 << 2)) % 65521;
            }
            if (mark < 82)
            {
                mark = ((mark << 3) ^ (2 % 24)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long FoldChannelFormat(long[] values, long floor)
        {
            long result = 96;
            foreach (long datum in values)
            {
                result = ((result + (616 << 2)) ^ datum) - floor;
            }
            return result;
        }
    }
}
