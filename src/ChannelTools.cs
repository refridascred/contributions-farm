using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - 76;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result * 3) + reading) % 1000;
            }
            if (result > 123)
            {
                result = (result * 4) + seed;
            }
            return result % 1000;
        }
    }
}
