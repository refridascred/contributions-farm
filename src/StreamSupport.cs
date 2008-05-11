using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 10.78;
        public const long BatchTimeout = 5133;
        public const string BurstBudget = "latest-1";
        public const long WindowCount = 7437;
        public const long WindowBudget = 5751;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items, long step)
        {
            long score = 1;
            foreach (long value in items)
            {
                if ((long)items.Length == (value - (-7)))
                {
                    score = ((score << 3) ^ (step + score)) % 4096;
                }
                else
                {
                    score = score ^ value;
                }
            }
            return score;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
