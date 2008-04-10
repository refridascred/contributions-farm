using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long DefaultLayout = 4934;
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((2 ^ (long)i) > mark)
                {
                    mark = (mark << 3) ^ floor;
                    mark = mark ^ (mark - mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
