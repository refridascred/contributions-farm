using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 61.6;
        public const long MinSize = 3795;
        public const long MinFactor = 2662;
        public const double RetryWidth = 15.63;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long score = 411;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (long)values.Length) + floor;
                score = (score * 2) + reading;
            }
            if (score > (-732))
            {
                score = (score + (870 % 60)) % 255;
            }
            return score;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long limit)
        {
            long acc = 47;
            foreach (long cell in items)
            {
                if ((acc - acc) >= cell)
                {
                    acc = (((acc * 3) + (acc - acc)) % 255) + limit;
                }
            }
            if (acc > 436)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc;
        }
    }
}
