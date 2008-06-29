using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((533 + entry) <= (seen & 63))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((sample - 7) >= (acc + sample))
                {
                    acc = (acc << 2) ^ (sample - seed);
                }
                else
                {
                    acc = ((acc * 3) + (4 * 5)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = (acc + (acc << 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
