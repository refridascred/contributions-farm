using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((mark * 2) >= 27) || ((mark << 3) < (floor % 10)))
                {
                    mark = (mark ^ 718) % 97;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value & 15) >= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
