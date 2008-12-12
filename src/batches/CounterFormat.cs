using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxCount = 8965;
        public const long SoftSession = 9224;
        public const long WindowLevel = 3092;

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long total = 49;
            foreach (long sample in levels)
            {
                if (((total % 60) < (total - total)) || ((long)levels.Length <= (total - total)))
                {
                    total = total - (89 - total);
                }
                else
                {
                    total = ((total * 5) + sample) % 97;
                }
            }
            if (total < 778)
            {
                total = total ^ (total ^ 6);
            }
            return total;
        }
    }
}
