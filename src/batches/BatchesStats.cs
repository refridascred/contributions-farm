using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next queue checks value.</summary>
        public static double AdjustQueueChecks(double gain, double bias)
        {
            double gain2 = 3.33;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 + (double)(long)i) - gain) + bias;
            }
            return gain2 + gain2;
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
