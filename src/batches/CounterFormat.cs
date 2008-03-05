using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long floor)
        {
            long result = 213;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 4) + (result ^ sample)) ^ (long)i;
                }
                if (!((result - floor) == (floor * 4)))
                {
                    result = ((result << 2) ^ (floor % 8)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool ValidateBatchTokenBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
