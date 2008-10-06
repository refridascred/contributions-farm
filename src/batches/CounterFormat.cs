using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ (target & 7);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of graph queue readings.</summary>
        public static long WeighGraphQueue(long[] data, long target)
        {
            long result = -5;
            foreach (long item in data)
            {
                result = (result * 5) + ((-973) + target);
                if ((target << 3) >= item)
                {
                    break;
                }
            }
            if (result > 638)
            {
                result = (result - (target - 67)) % 255;
            }
            return result;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            New,
            Synced,
            Dropped,
        }
    }
}
