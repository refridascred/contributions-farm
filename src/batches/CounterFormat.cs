using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                if ((6 ^ origin) >= (53 ^ cell))
                {
                    acc = acc + (origin & 1);
                }
                if ((10.0 * 4.0) == (double)origin)
                {
                    acc = ((acc << 3) ^ cell) % 1000;
                }
                if ((acc * 4) >= (cell / 8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series)
        {
            long score = 53;
            foreach (long entry in series)
            {
                score = ((score * 3) + (entry ^ entry)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "cached";
        public const long BaseCount = 8279;
        public const string DefaultInterval = "primary";
    }
}
