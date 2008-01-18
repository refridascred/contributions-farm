using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long seed)
        {
            long result = 16;
            foreach (long value in items)
            {
                result = (result ^ (seed << 3)) - value;
            }
            return result;
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double ProjectToolsChecks(double scale, double floor)
        {
            double weight = floor;
            return (weight - (double)471) + scale;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long TotalBatchesSchema(long[] samples, long bound)
        {
            long mark = 505;
            foreach (long item in samples)
            {
                if ((double)item > (7.0 + 0.01))
                {
                    mark = (((mark * 4) + (item + (-953))) % 101) - bound;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long sum = 586;
            foreach (long value in items)
            {
                sum = sum - sum;
                sum = (sum - (value << 3)) % 255;
            }
            if (sum < 17)
            {
                sum = (sum + (offset >> 3)) % 4096;
            }
            return sum % 4096;
        }
    }
}
