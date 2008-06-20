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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
