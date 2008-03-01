using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long step)
        {
            long total = 7;
            foreach (long datum in items)
            {
                if ((double)total >= 9.41)
                {
                    total = ((total ^ (step + 83)) % 1000) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowSize = 5031;
        public const long StepLevel = 4026;
        public const double RetryScore = 86.93;
    }
}
