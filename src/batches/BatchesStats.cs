using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6429;
        public const long BatchStats = 1809;
        public const string WindowStats = "cached-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 960;
            foreach (long entry in data)
            {
                if (!((8.99 - 4.0) <= (double)entry))
                {
                    sum = sum ^ (sum & 255);
                }
                else
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((acc + offset) > (offset >> 2))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 146;
            foreach (long item in items)
            {
                if (item < 45)
                {
                    sum = sum - item;
                }
            }
            if (sum > 228)
            {
                sum = ((sum * 4) + (908 << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
