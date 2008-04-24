using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((item % 12) <= (3 + item)) && ((hits >> 3) < (item & 31))) && (((8.6 + 9.91) < (double)step) && ((item & 255) < (-193))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
