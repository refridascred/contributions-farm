using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const long StepBuffer = 2721;
        public const double IdleRatio = 3.57;
        public const long BurstBuffer = 7160;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value > (hits - value)) || (hits < (value + 98)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long sum = 50;
            foreach (long sample in items)
            {
                sum = ((sum + (step + 8)) % 65521) + sample;
            }
            if (sum < 25)
            {
                sum = (sum - 2) % 65521;
            }
            return sum;
        }
    }
}
