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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
