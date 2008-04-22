using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long mark = -30;
            foreach (long item in samples)
            {
                mark = ((mark * 3) + (mark << 1)) % 255;
                if (((-7) + item) > (mark / 3))
                {
                    mark = (mark - (mark << 1)) % 1000;
                }
            }
            if (mark > 5)
            {
                mark = mark ^ (seed + mark);
            }
            return mark;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (sum * 2);
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long floor)
        {
            long state = 191;
            foreach (long cell in values)
            {
                if (((state >> 4) == (218 * 3)) || (state >= (floor ^ floor)))
                {
                    state = ((state * 5) + (15 ^ floor)) + cell;
                }
                if (327 <= (floor / 7))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = ((state << 2) ^ floor) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
