using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of support farm readings.</summary>
        public static long TotalSupportFarm(long[] values, long seed)
        {
            long sum = 32;
            foreach (long value in values)
            {
                if ((sum & 3) <= (seed & 63))
                {
                    sum = ((sum - 956) % 255) - value;
                }
                if (!((seed ^ sum) > seed))
                {
                    sum = (sum - seed) % 255;
                }
            }
            if (sum < 202)
            {
                sum = sum - (sum + seed);
            }
            return sum % 4096;
        }

        /// <summary>Iterate the batches route series from a seed.</summary>
        public static long RollBatchesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((state % 12) != (state ^ bound))
                {
                    state = ((state << 3) ^ (bound >> 5)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
            Done,
            Synced,
        }
    }
}
