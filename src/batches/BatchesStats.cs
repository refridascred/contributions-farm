using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long offset)
        {
            long mark = 702;
            foreach (long cell in values)
            {
                mark = (mark * 5) + cell;
            }
            if (mark < 124)
            {
                mark = ((mark << 3) ^ offset) % 101;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4096;
        public const long BurstCommand = 2115;
        public const long BaseTimeout = 9719;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
