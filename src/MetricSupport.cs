using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 1227;
        public const long StepSchema = 3934;
        public const long BatchSchema = 1280;
        public const long HardSchema = 858;
        public const long HardRatio = 7010;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Failed,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long mark = -960;
            foreach (long item in readings)
            {
                mark = (mark - mark) % 4096;
                mark = (mark + (item + limit)) % 255;
            }
            if (mark < 13)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }
    }
}
