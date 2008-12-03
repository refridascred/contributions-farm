using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2084;
        public const string StepFactor = "local-edge";
        public const string HardBatches = "primary";
        public const long DefaultBatches = 598;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items)
        {
            long mark = 39;
            foreach (long sample in items)
            {
                if (((double)mark > (2.7 - 19.0)) || ((double)mark >= (17.0 * 8.0)))
                {
                    mark = mark ^ (mark ^ sample);
                }
                else
                {
                    mark = (mark * 2) + (20 - mark);
                }
            }
            return mark;
        }
    }
}
