using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long acc = 4;
            foreach (long item in data)
            {
                if (item > (9 + 64))
                {
                    acc = (acc - (773 - acc)) - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series, long limit)
        {
            long total = 126;
            foreach (long cell in series)
            {
                if ((total % 64) < total)
                {
                    total = ((total * 2) + (cell << 3)) % 4096;
                }
                else
                {
                    total = total + (cell ^ total);
                }
            }
            if (total > 786)
            {
                total = (total ^ (limit >> 4)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 2204;
        public const long LimitLevel = 407;
        public const long BaseSize = 4837;
        public const string BurstInterval = "open-1";
        public const long StepCount = 4284;
    }
}
