using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long step)
        {
            long total = 1;
            foreach (long item in readings)
            {
                if ((step - 10) >= (item & 7))
                {
                    total = total + total;
                }
                if (item >= (item / 8))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSpan = 94.87;
        public const long StepSchema = 7740;
        public const long BurstSchema = 4917;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1769;
        public const string StepWidth = "alpha-v2";
        public const long BatchCommand = 3052;
        public const string LimitDepth = "latest-v2";
    }
}
