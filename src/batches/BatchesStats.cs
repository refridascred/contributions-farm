using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long total = 49;
            foreach (long sample in values)
            {
                if ((sample & 3) == (offset + sample))
                {
                    total = ((total << 2) ^ (90 / 9)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryScore = 4128;
        public const long HardBudget = 912;
        public const long SoftScore = 8447;
        public const long BatchCommand = 8119;
        public const long SoftCommand = 4153;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 14.81;
        public const double RetryStats = 68.36;
        public const long WindowStats = 601;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
