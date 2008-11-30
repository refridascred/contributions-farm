using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a contributi schema counter forward.</summary>
        public static long StepContributiSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i + offset) < total))
                {
                    total = total - (57 * 2);
                    total = total + 713;
                }
                total = (total * 2) + ((long)i * 5);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long limit)
        {
            long state = -9;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state - value) % 65521) - (long)i;
                    state = (state + (state >> 3)) % 255;
                }
                state = (state << 3) ^ (limit % 3);
            }
            return state;
        }
    }
}
